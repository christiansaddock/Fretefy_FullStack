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
                var sheet = package.Workbook.Worksheets.Add("Região");
                sheet.Cells[1, 1].Value = "ID";
                sheet.Cells[1, 2].Value = "Nome";

                sheet.Cells[2, 1].Value = regiao.Id.ToString();
                sheet.Cells[2, 2].Value = regiao.Nome;

                var sheetCidades = package.Workbook.Worksheets.Add("Cidades");
                sheetCidades.Cells[1, 1].Value = "ID";
                sheetCidades.Cells[1, 2].Value = "Nome";
                sheetCidades.Cells[1, 3].Value = "UF";

                int row = 2;
                foreach (var cidade in regiao.Cidades)
                {
                    sheetCidades.Cells[row, 1].Value = cidade.Id.ToString();
                    sheetCidades.Cells[row, 2].Value = cidade.Nome;
                    sheetCidades.Cells[row, 3].Value = cidade.UF;
                    row++;
                }

                return package.GetAsByteArray();
            }
        }
        public async Task<Regiao> Get(Guid id)
        {
           return await _regiaoRepository.Get(id);
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
