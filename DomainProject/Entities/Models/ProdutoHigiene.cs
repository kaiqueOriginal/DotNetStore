using System;
using System.Collections.Generic;
using System.Text;

namespace DomainProject.Entities.Models
{
    public class ProdutoHigiene : Produto
    {
        public int AnimalId { get; set; }
        public virtual Animal Animal { get; set; }
        public string Ambiente { get; set; }
        public bool Toxico { get; set; }
        public int Quantidade { get; set; }
        public float Peso { get; set; }
        public string Fabricante { get; set; }
        public string Material { get; set; }
    }
}
