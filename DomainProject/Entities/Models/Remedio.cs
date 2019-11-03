using DomainProject.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainProject.Entities.Models
{
    public class Remedio : Produto
    {
        public bool PrecisaReceita { get; set; }
        public int AnimalId { get; set; }
        public virtual Animal Animal { get; set; }
        public TipoRemedio Tipo { get; set; }
        public int Quantidade { get; set; }
    }
}
