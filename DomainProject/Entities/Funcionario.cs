using DomainProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainProject.Entities
{
    public class Funcionario : IPessoa
    {
        public int Id { get; set; }
        public string Nome { get; set ; }
        public string nick { get; set; }
        public long password { get; set; }
    }
}
