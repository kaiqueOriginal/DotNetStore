using DomainProject.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainProject.Entities
{
    public class Iscas : Produto
    {
        public string Material { get; set; }
        public DateTime Validade { get; set; }
        public string Fabricante { get; set; }
        public string Aroma { get; set; }
        public float Peso { get; set; }
        public int Quantidade { get; set; }

    }
}