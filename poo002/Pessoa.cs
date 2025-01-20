using System;

namespace poo002
{
    class Pessoa
    {
        // Método 01
        public void Apresentar()
        {
            Console.WriteLine("Olá.");
        }


        // Método 02

        public void Apresentar(string nome)
        {
            Console.WriteLine($"Olá, {nome}.");
        }

        // Método 03

        public void Apresentar(string nome, int idade)
        {
            Console.WriteLine($"Olá, {nome} você tem {idade} anos.");
        }
    }
}
