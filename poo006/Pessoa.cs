using System;

namespace poo006
{
    internal class Pessoa
    {
        // Construtor
        public Pessoa()
        {
            Console.WriteLine("Construtor Executado!");
        }

        // Construtor com Parâmetro
        public Pessoa(string nome)
        {
            Console.WriteLine($"Olá, {nome}");
        }

    }
}
