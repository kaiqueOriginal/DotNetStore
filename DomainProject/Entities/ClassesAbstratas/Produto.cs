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
        public DateTime UltimaModificacao { get; set; }
        public DateTime DataInsercao { get; set; }

        public Produto(double preco,string fotosPath,string descricao,DateTime ultimaModificacao)
        {
            Preco = preco;
            Fotos = fotosPath;
            Descricao = descricao;
            UltimaModificacao = ultimaModificacao;
            DataInsercao = ultimaModificacao;
        }



    }
}
