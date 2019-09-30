using System;
using System.Collections.Generic;
using System.Text;

namespace DomainProject.Entities.Models
{
    class Viveiros : Produto
    {
        public int Suportes { get; set; }
        public int Litragem { get; set; }
        public float Peso { get; set; }
        public string Medidas { get; set; }
        public string Material { get; set; }
    }
}
