using DomainProject.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainProject.Entities.Models
{
    public class EquipamentoPesca : Produto
    {
        public int CapacidadeCarretel { get; set; }
        public string Fabricante { get; set; }
        public string Material { get; set; }
        public int Rolamentos { get; set; }
        public string FreioTipo { get; set; }
        public Lado Manivela { get; set; }
    }
}
