using System;

namespace Exemplo_Teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Boa tarde: {0}", nome);
        }
    }
}
