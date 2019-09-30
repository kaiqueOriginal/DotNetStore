using System;
using System.Collections.Generic;
using System.Text;

namespace DomainProject.Entities.Models
{
    class Estoque
    {
        public int Id { get; set; }
        public Produto Prduto { get; set; }
        public int Quantidade { get; set; }
        public Local Local { get; set; }
        public DateTime Chegada { get; set; }
        public DateTime Validade { get; set; }
    }
}
