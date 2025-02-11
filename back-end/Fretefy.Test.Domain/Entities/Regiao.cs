using System;
using System.Collections.Generic;
using System.Text;

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
        public List<Cidade> Cidades { get; set; }
    }
}
