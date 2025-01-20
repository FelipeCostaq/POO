using System;

namespace poo001
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Objeto
            Pessoa pessoa01 = new Pessoa();
            pessoa01.nome = "Felipe";
            pessoa01.idade = 16;

            pessoa01.Mensagem();

        }
    }
}
