using System;


namespace poo002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa01 = new Pessoa();
            pessoa01.Apresentar();
            pessoa01.Apresentar("Felipe");
            pessoa01.Apresentar("Jorge", 20);
        }
    }
}
