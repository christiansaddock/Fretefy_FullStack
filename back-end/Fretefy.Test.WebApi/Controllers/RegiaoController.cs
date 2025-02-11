using AutoMapper;
using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Services;
using Fretefy.Test.WebApi.Data.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fretefy.Test.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegiaoController : ControllerBase
    {
        private readonly IRegiaoService _regiaoService;
        private readonly IMapper _mapper;
        public RegiaoController(IRegiaoService regiaoService, IMapper mapper)
        {
            _regiaoService = regiaoService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IEnumerable<RegiaoDto>> GetAll()
        {
            var regioes =  await _regiaoService.List();
            return _mapper.Map<IEnumerable<RegiaoDto>>(regioes);
        }

        [HttpGet("{id}")]
        public async Task<RegiaoDto> Get(Guid id)
        {
            var regiao = await _regiaoService.Get(id);
            return _mapper.Map<RegiaoDto>(regiao);
        }
        

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] RegiaoCreate regiao)
        {
            try
            {
                var addRegiao = _mapper.Map<Regiao>(regiao);
                await _regiaoService.AddRegiao(addRegiao);
                return Ok("Região cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message, Errors = ex.Message });
            }
        }

        [HttpPut]
        public async Task Put([FromBody] RegiaoUpdate regiao)
        {
            var editRegiao = _mapper.Map<Regiao>(regiao);
            await _regiaoService.UpdateRegiao(editRegiao);
        }

        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await _regiaoService.DeleteRegiao(id);
        }

        [HttpGet("{id}/export")]
        public async Task<IActionResult> ExportToExcel(Guid id)
        {
            try
            {
                var fileContent = await _regiaoService.ExportDataAsync(id);
                return File(fileContent, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Regiao.xlsx");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
