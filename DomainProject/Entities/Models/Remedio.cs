using DomainProject.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainProject.Entities.Models
{
    class Remedio : Produto
    {
        public bool PrecisaReceita { get; set; }
        public Animal Animal { get; set; }
        public TipoRemedio Tipo { get; set; }
        public int Quantidade { get; set; }
    }
}
