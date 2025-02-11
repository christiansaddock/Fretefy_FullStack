using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Fretefy.Test.Domain.Services
{
    public class CidadeService : ICidadeService
    {
        private readonly ICidadeRepository _cidadeRepository;
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;

        public CidadeService(ICidadeRepository cidadeRepository, HttpClient httpClient, IConfiguration configuration)
        {
            _cidadeRepository = cidadeRepository;
            _httpClient = httpClient;
            _apiKey = configuration["OpenCageData"];
        }

        public async Task AddCidade(Cidade cidade)
        {
            (cidade.Lat, cidade.Longi) = await ObterCoordenadasAsync(cidade.Nome);
            await _cidadeRepository.Add(cidade);
        }

        public async Task DeleteCidade(Guid id)
        {
            await _cidadeRepository.Delete(id);
        }

        public async Task<Cidade> Get(Guid id)
        {
            return await _cidadeRepository.Get(id);
        }

        public async Task<IEnumerable<Cidade>> List()
        {
            return await _cidadeRepository.List();
        }

        public async Task<IEnumerable<Cidade>> ListByUf(string uf)
        {
            return await _cidadeRepository.ListByUf(uf);
        }

        public async Task<IEnumerable<Cidade>> Query(string terms)
        {
            return await _cidadeRepository.Query(terms);
        }

        public async Task UpdateCidade(Cidade cidade)
        {
            var cidadeExistente = await _cidadeRepository.Get(cidade.Id);

            if (cidadeExistente == null)
            {
                throw new Exception("Cidade não encontrada no banco de dados.");
            }

            cidadeExistente.Nome = cidade.Nome;
            cidadeExistente.UF = cidade.UF;
            cidadeExistente.Lat = cidade.Lat;
            cidadeExistente.Longi = cidade.Longi;

            if (cidade.RegiaoId != null)
            {
                cidade.RegiaoId = cidadeExistente.RegiaoId;
            }

            await _cidadeRepository.Update(cidadeExistente);
        }

        private async Task<(double Latitude, double Longitude)> ObterCoordenadasAsync(string cidade)
        {
            string url = $"https://api.opencagedata.com/geocode/v1/json?q={Uri.EscapeDataString(cidade)}&key={_apiKey}";

            HttpResponseMessage response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();
            using JsonDocument json = JsonDocument.Parse(responseBody);

            var results = json.RootElement.GetProperty("results");
            if (results.GetArrayLength() > 0)
            {
                var location = results[0].GetProperty("geometry");
                double latitude = location.GetProperty("lat").GetDouble();
                double longitude = location.GetProperty("lng").GetDouble();

                return (latitude, longitude);
            }

           return(0,0);
        }
    }
}
