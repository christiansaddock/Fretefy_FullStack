using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fretefy.Test.Domain.Entities
{
    public class Cidade : IEntity
    {
        public Cidade()
        {
        
        }

        public Cidade(string nome, string uf)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            UF = uf;
        }

        [Key]
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string UF { get; set; }
        public double? Lat { get; set; }
        public double? Longi { get; set; }
        public Guid RegiaoId { get; set; }
        [JsonIgnore]
        public virtual Regiao Regiao { get; set; }

    }
}
