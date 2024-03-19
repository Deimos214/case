using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a opção A, B ou C.");
            string opcao = Console.ReadLine().ToUpper();

            if (opcao == "A")
                Console.WriteLine("A opção selecionada foi A.");
            else if (opcao == "B")
                Console.WriteLine("A opção selecionada foi B.");
            else if (opcao == "C")
                Console.WriteLine("A opção selecionada foi C.");
            else
                Console.WriteLine("Opção inválida.");

            Console.ReadKey();
        }
    }
}
