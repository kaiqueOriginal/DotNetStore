using System;
using System.Collections.Generic;
using System.Text;

namespace DomainProject.Entities.Models
{
    public class Viveiro : Produto
    {
        public int AnimalId { get; set; }
        public virtual Animal Animal { get; set; }
        public int Suportes { get; set; }
        public int Litragem { get; set; }
        public float Peso { get; set; }
        public string Medidas { get; set; }
        public string Material { get; set; }
    }
}
