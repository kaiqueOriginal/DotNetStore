using System;
using System.Collections.Generic;
using System.Text;

namespace DomainProject.Entities.Models
{
    public class Decoracao : Produto
    {
        public int AnimalId { get; set; }
        public virtual Animal Animal { get; set; }

        public float Peso { get; set; }
        public int Quantidade { get; set; }
        public string Material { get; set; }

    }
}
