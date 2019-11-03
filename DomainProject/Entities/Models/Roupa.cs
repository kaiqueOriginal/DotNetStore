using System;
using System.Collections.Generic;
using System.Text;

namespace DomainProject.Entities.Models
{
    public class Roupa : Produto
    {
        public char Tamanho { get; set; }
        public string Material { get; set; }
        public int FatorProtecaoUV { get; set; }
        public float Peso { get; set; }
        public bool AprovaDagua { get; set; }
        public int AnimalId { get; set; }
        public virtual Animal Animal { get; set; }
        public string Tipo { get; set; }


    }
}
