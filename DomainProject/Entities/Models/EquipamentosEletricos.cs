using DomainProject.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainProject.Entities.Models
{
    class EquipamentosEletricos : Produto
    {
        public Corrente TipoCorrente { get; set; }
        public tensao Tensao { get; set; }
        public string Potencia { get; set; }
        public float Peso { get; set; }
    }
}
