using System;

namespace poo001
{
    class Pessoa
    {
        //Atributos

        public string nome;
        public int idade;

        //Métodos
        
        public void Mensagem()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
        }

    }
}
