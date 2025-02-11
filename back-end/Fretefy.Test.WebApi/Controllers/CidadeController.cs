using AutoMapper;
using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces;
using Fretefy.Test.Domain.Interfaces.Services;
using Fretefy.Test.WebApi.Data.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fretefy.Test.WebApi.Controllers
{
    [Route("api/cidade")]
    [ApiController]
    public class CidadeController : ControllerBase
    {
        private readonly ICidadeService _cidadeService;
        private readonly IMapper _mapper;

        public CidadeController(ICidadeService cidadeService, IMapper mapper)
        {
            _cidadeService = cidadeService;
            _mapper = mapper;
        }

        [HttpGet("list")]
        public async Task<IActionResult> List([FromQuery] string uf, [FromQuery] string terms)
        {
            IEnumerable<Cidade> cidades;

            if (!string.IsNullOrEmpty(terms))
                cidades = await _cidadeService.Query(terms);
            else if (!string.IsNullOrEmpty(uf))
                cidades = await _cidadeService.ListByUf(uf);
            else
                cidades = await _cidadeService.List();

            return Ok(cidades);
        }
      
        [HttpGet]
        public async Task<IEnumerable<CidadeGet>> GetAll()
        {
            var cidades = await _cidadeService.List();
            return _mapper.Map<IEnumerable<CidadeGet>>(cidades);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CidadeDto>> Get(Guid id)
        {
            var regiao = await _cidadeService.Get(id);
            return Ok(_mapper.Map<CidadeDto>(regiao));
        }


        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CidadeCreate cidade)
        {
            try
            {
                var addCidade = _mapper.Map<Cidade>(cidade);
                await _cidadeService.AddCidade(addCidade);
                return Ok("Cidade cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message, Errors = ex.Message });
            }
        }

        [HttpPut]
        public async Task Put([FromBody] CidadeUpdate cidade)
        {
            var editCidade = _mapper.Map<Cidade>(cidade);
            await _cidadeService.UpdateCidade(editCidade);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                await _cidadeService.DeleteCidade(id);
                return Ok();

            }
            catch (Exception ex)
            {

                return StatusCode(500, new { Message = "Erro interno no servidor", Details = ex.Message });
            }
        }
    }
}
