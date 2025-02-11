using Fretefy.Test.Domain.Entities;
using System.Collections.Generic;
using System;

namespace Fretefy.Test.WebApi.Data.Dtos
{
    public class RegiaoDto
    {
        public RegiaoDto()
        {

        }

        public RegiaoDto(string nome)
        {
            Nome = nome;
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
    }
}
