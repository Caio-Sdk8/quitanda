using System;

namespace listaobjs.classes
{
    public class Produto
    {
        private string Codigo {get; set;}

        public string Nome{get;}

        public float Preco{get;}

        public string id {get;}

        public int QuantiEstoque{get;}

        public Produto(string nome, float preco, int quantiestoque){
            Random codigo = new Random(90000000);
            
            this.Codigo = codigo.ToString();
            this.id = Codigo;
            this.Nome = nome;
            this.Preco = preco;
            this.QuantiEstoque = quantiestoque;
        }
    }
}