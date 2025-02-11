using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Fretefy.Test.Domain.Interfaces.Services;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Fretefy.Test.Domain.Services
{
    public class RegiaoService : IRegiaoService
    {
        private readonly IRegiaoRepository _regiaoRepository;

        public RegiaoService(IRegiaoRepository regiaoRepository)
        {
            _regiaoRepository = regiaoRepository;
        }
        public async Task AddRegiao(Regiao regiao)
        {
            await _regiaoRepository.Add(regiao);
        }

        public async Task DeleteRegiao(Guid id)
        {
            await _regiaoRepository.Delete(id);
        }

        public async Task<byte[]> ExportDataAsync(Guid regiaoId)
        {
            var regiao = await _regiaoRepository.GetRegionInner(regiaoId);
            if (regiao == null)
                throw new Exception("Região não encontrada.");

            using (var package = new ExcelPackage())
            {
                var sheet = package.Workbook.Worksheets.Add("Regiao e Cidades");

                sheet.Cells[1, 1].Value = "ID Região";
                sheet.Cells[1, 2].Value = "Nome Região";
                sheet.Cells[1, 3].Value = "ID Cidade";
                sheet.Cells[1, 4].Value = "Nome Cidade";
                sheet.Cells[1, 5].Value = "UF";
                sheet.Cells[1, 6].Value = "Lat";
                sheet.Cells[1, 7].Value = "Longi";

                int row = 2;
                foreach (var cidade in regiao.Cidades)
                {
                    sheet.Cells[row, 1].Value = regiao.Id.ToString();
                    sheet.Cells[row, 2].Value = regiao.Nome;
                    sheet.Cells[row, 3].Value = cidade.Id.ToString();
                    sheet.Cells[row, 4].Value = cidade.Nome;
                    sheet.Cells[row, 5].Value = cidade.UF;
                    sheet.Cells[row, 6].Value = cidade.Lat;
                    sheet.Cells[row, 7].Value = cidade.Longi;
                    row++;
                }
                return package.GetAsByteArray();
            }
        }
        public async Task<Regiao> Get(Guid id)
        {
           return await _regiaoRepository.Get(id);
        }

        public async Task<Regiao> GetRegionInner(Guid id)
        {
            return await _regiaoRepository.GetRegionInner(id);
        }

        public async Task<IEnumerable<Regiao>> List()
        {
            return await _regiaoRepository.GetAll();
        }

        public async Task<IEnumerable<Regiao>> ListByUf(string uf)
        {
            return await _regiaoRepository.ListByUf(uf);
        }

        public Task<IEnumerable<Regiao>> Query(string terms)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateRegiao(Regiao regiao)
        {
            await _regiaoRepository.Update(regiao);    
        }
    }
}
