using System;

namespace Fretefy.Test.WebApi.Data.Dtos
{
    public class CidadeCreate
    {
        public string Nome { get; set; }
        public string UF { get; set; }
        public Guid RegiaoId { get; set; }
    }
}
