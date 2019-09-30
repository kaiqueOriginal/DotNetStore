using DomainProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainProject.Entities
{
    public abstract class Produto :IProduto
    {
        //Categoria
        public int Id { get; set; }
        public double Preco { get; set; }
        public string Fotos { get; set; }
        public string Descricao { get; set; }
        public DateTime StampDateTime { get; set; }
        public DateTime Insercao { get; set; }


    }
}
