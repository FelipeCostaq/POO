using System;

namespace poo004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa teste01 = new Pessoa();
            while (true)
            {
                try
                {
                    Console.Write("Qual sua altura?: ");
                    teste01.altura = double.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("[ERROR] Tente novamente!");
                }
            }
            while (true)
            {
                try
                {
                    Console.Write("Qual sua peso?: ");
                    teste01.peso = double.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("[ERROR] Tente novamente!");
                }
            }
            teste01.Mensagem();
        }
    }
}
