using DomainProject.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainProject.Entities.Models
{
    class Vara : Produto
    {
        public string Fabricante { get; set; }
        public TipoVara Tipo { get; set; }
        public float Tamanho { get; set; }
        public float Peso { get; set; }
        public int Libragem { get; set; }
        public int Passadores { get; set; }
        public bool isInteirica { get; set; }
        public TipoAcao Acao { get; set; }

    }
}
