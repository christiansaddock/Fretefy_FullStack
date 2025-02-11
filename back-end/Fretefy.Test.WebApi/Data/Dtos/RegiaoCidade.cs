using Fretefy.Test.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Fretefy.Test.WebApi.Data.Dtos
{
    public class RegiaoCidade
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        public List<Cidade> Cidades { get; set; }


    }
}
