using System;
using System.Collections.Generic;
using System.Text;

namespace DomainProject.Entities.Models
{
    class Manutencao : Produto
    {
        public Animal animal { get; set; }
        public float Peso { get; set; }
        public int Quantidade { get; set; }
        public DateTime Validade { get; set; }
    }
}
