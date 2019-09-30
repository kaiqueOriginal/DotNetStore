using System;
using System.Collections.Generic;
using System.Text;

namespace DomainProject.Entities.Models
{
    class Decoracao : Produto
    {
        public Animal Animal { get; set; }
        public float Peso { get; set; }
        public int Quantidade { get; set; }
        public string Material { get; set; }

    }
}
