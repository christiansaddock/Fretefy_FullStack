using System;

namespace Fretefy.Test.WebApi.Data.Dtos
{
    public class CidadeUpdate
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string UF { get; set; }
        public double? Lat { get; set; }
        public double? Long { get; set; }
    }
}
