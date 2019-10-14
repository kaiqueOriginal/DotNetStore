using System;
using System.Collections.Generic;
using System.Text;

namespace DomainProject.Entities.Models
{
    public class Roupas : Produto
    {
        public char Tamanho { get; set; }
        public string Material { get; set; }
        public int FatorProtecaoUV { get; set; }
        public float Peso { get; set; }
        public bool AprovaDagua { get; set; }
        public string Especies { get; set; }
        public string Tipo { get; set; }


    }
}
