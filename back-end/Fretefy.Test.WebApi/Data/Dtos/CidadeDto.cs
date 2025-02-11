using Fretefy.Test.Domain.Entities;
using System;

namespace Fretefy.Test.WebApi.Data.Dtos
{
    public class CidadeDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string UF { get; set; }
        public double? Lat { get; set; }
        public double? Long { get; set; }
        public Guid RegiaoId { get; set; }
        public Regiao Regiao { get; set; }
    }
}
