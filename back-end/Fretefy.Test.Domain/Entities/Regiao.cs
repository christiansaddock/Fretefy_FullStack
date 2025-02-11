using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Fretefy.Test.Domain.Entities
{
    public class Regiao : IEntity
    {

        public Regiao()
        {
            
        }
        public Regiao(string nome)
        {
            Id = Guid.NewGuid();
            Nome = nome;
                
        }
        public Guid Id { get; set; }
        public string Nome { get; set; }
        [JsonIgnore]
        public virtual List<Cidade> Cidades { get; set; }
    }
}
