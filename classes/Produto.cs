using System;

namespace listaobjs.classes
{
    public class Produto
    {
        private string Codigo {get; set;}

        public string Nome{get; set;}

        public float Preco{get; set;}

        public int id {get; set;}

        public int QuantiEstoque{get; set;}

        public Produto(string nome, float preco, int quantiestoque){
            Random codigo = new Random(99999999);
            
            this.Codigo = codigo.ToString();
            this.Nome = nome;
            this.Preco = preco;
            this.QuantiEstoque = quantiestoque;
        }
    }
}