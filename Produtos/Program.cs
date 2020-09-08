using Produtos.Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> list = new List<Produto>();

            Console.Write("Entre com o numero dos produtos: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Data #" + i + " produto:");
                Console.Write("O produto eh usado(u), novo(c) ou importado(i) (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                String nome = Console.ReadLine();
                Console.Write("Preco: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (type == 'c')
                {
                    list.Add(new Produto(nome, preco));
                }
                else if (type == 'u')
                {
                    Console.Write("Data da fabricao (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new ProdutoUsado(nome, preco, date));
                }
                else
                {
                    Console.Write("Customs fee: ");
                    double custoAlfandega = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ProdutoImportado(nome, preco, custoAlfandega));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Etiqueta do Produto:");
            foreach (Produto prod in list)
            {
                Console.WriteLine(prod.Etiqueta());
            }
        }
    }
}
