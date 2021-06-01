using System;
using System.Collections.Generic;
using listaobjs.classes;

namespace listaobjs
{
    class Program
    {
        static void Main(string[] args)
        {
            bool rep1 = false;
            bool rep2 = false;
            bool rep3 = false;

            List<Produto> produtos = new List<Produto>();

            Console.WriteLine("Bem vindo a quitandinha do seu zé");

            do
            {

                Console.WriteLine(@"
                __________________________________
                |        BEM VINDO AO MENU       |
                | 1-Cadastrar um protudo novo    |
                | 2-Listar produtos              |
                | 3-Modificar e listar produto   |
                | 4-Excluir produto              |
                | 5-Sair                         |
                ----------------------------------");
                int repetir = int.Parse(Console.ReadLine());

                switch (repetir)
                {
                    case 1:
                        Console.WriteLine("Qual o nome do Produto?");
                        string nome = Console.ReadLine();

                        Console.WriteLine($"Qual o preço do {nome}?");
                        float preco = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Quantos {nome} ainda temos em estoque?");
                        int quantiestoque = int.Parse(Console.ReadLine());

                        produtos.Add(new Produto(nome, preco, quantiestoque));
                        rep1 = true;
                        break;
                    case 2:
                        foreach (Produto item in produtos)
                        {
                            Console.WriteLine($@"
                        Código do produto: {item.id}
                        Nome do produto: {item.Nome}
                        Preço do produto: {item.Preco}
                        Quantidade em estoque: {item.QuantiEstoque}
                        ");

                            Console.WriteLine("Você será levado ao menu de novo.");
                            rep1 = true;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Qual o nome do produto que você deseja atualizar?");
                        string nomeado = Console.ReadLine();


                        Console.WriteLine(@"
                __________________________________
                |     BEM VINDO AO MENU MUDAR    |
                | 1-Mudar nome do produto        |
                | 2-Mudar Preço do produto       |
                | 3-Mudar quantidade em estoque  |
                ----------------------------------");
                        int escolha = int.Parse(Console.ReadLine());

                        switch (escolha)
                        {
                            case 1:
                            Produto atualizar = produtos.Find(item => item.Nome == nomeado);
                                break;
                            case 2:
                            Produto atualizar2 = produtos.Find(item => item.Nome == nomeado);
                                break;
                            case 3:
                            Produto atualizar3 = produtos.Find(item => item.Nome == nomeado);
                                break;
                            default:
                                break;
                        }
                        break;
                    case 4:
                        Console.WriteLine("Qual o nome do produto que você deseja excluir?");
                        string nominho = Console.ReadLine();

                        produtos.RemoveAll(item => item.Nome == nominho);

                        Console.WriteLine("Você será levado ao menu de novo.");

                        rep1 = true;
                        break;
                    case 5:
                        rep1 = false;
                        break;
                    default:
                        break;
                }

            } while (rep1);
        }
    }
}
