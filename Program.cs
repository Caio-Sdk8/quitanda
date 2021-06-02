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
                        Preço do produto: {item.Preco:C2}
                        Quantidade em estoque: {item.QuantiEstoque}
                        ");

                        }
                        Console.WriteLine("Você será levado ao menu de novo.");
                        rep1 = true;
                        break;
                    case 3:
                        Console.WriteLine("Qual o nome do produto que você deseja atualizar?");
                        string nomemud = Console.ReadLine();

                        do
                        {

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
                                    Console.WriteLine("Qual o novo nome do produto?");
                                    string novonome = Console.ReadLine();

                                    produtos.Find(item => item.Nome == nomemud).Nome = novonome;

                                    Console.WriteLine("Você será levado ao menu de novo.");
                                    rep2 = false;
                                    break;
                                case 2:
                                    Console.WriteLine("Qual o novo preço do produto?");
                                    float novopreco = float.Parse(Console.ReadLine());

                                    produtos.Find(item => item.Nome == nomemud).Preco = novopreco;

                                    Console.WriteLine("Você será levado ao menu de novo.");
                                    rep2 = false;
                                    break;
                                case 3:
                                    Console.WriteLine("Qual o novo estoque do produto?");
                                    int novoestoque = int.Parse(Console.ReadLine());

                                    produtos.Find(item => item.Nome == nomemud).QuantiEstoque = novoestoque;

                                    Console.WriteLine("Você será levado ao menu de novo.");
                                    rep2 = false;
                                    break;
                                default:
                                    Console.WriteLine("Numero invalido, lhe falta inteligencia, volte desde o começo e faça certo agora.");
                                    rep2 = true;
                                    break;
                            }
                        } while (rep2);
                        rep1 = true;
                        break;
                    case 4:
                        Console.WriteLine("Qual o nome do produto que você deseja excluir?");
                        string nominho = Console.ReadLine();

                        produtos.RemoveAll(item => item.Nome == nominho);

                        Console.WriteLine("Você será levado ao menu de novo.");

                        rep1 = true;
                        break;
                    case 5:
                        Console.WriteLine("Tchauzinho usuario.");
                        rep1 = false;
                        break;
                    default:
                        break;
                }

            } while (rep1);
        }
    }
}
