using System;

namespace NomeUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, Usuário");
            Console.WriteLine("----------------------");
            Console.Write("Por favor, digite seu nome: ");

            string nome = Console.ReadLine();

            Console.Write("Olá, ");
            Console.WriteLine(nome);
            Console.WriteLine();

            Console.Write("Agora digite seu sobrenome: ");
            string sobrenome = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Seu nome completo é; " + nome + " " + sobrenome);
            Console.Write("Seu nome de catálago é: ");
            Console.Write($"{sobrenome.ToUpper()}"  + ", " + $"{nome.ToString()}");
        }
    }
}
