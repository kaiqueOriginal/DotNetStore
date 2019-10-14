using System;
using System.Collections.Generic;
using System.Text;

namespace DomainProject.Entities.Models
{
    public class Camping : Produto
    {
        public string Tamanho { get; set; }
        public string Material { get; set; }
        public float Peso { get; set; }

    }
}
