using System;

namespace poo005
{
    internal class Aluno
    {
        // Atributos
        private double nota1, nota2;

        // Média
        private double Media()
        {
            return (nota1 + nota2) / 2;
        }

        // Mensagem
        public void Mensagem()
        {
            Console.Write("Nota 1: ");
            nota1 = int.Parse(Console.ReadLine());
            Console.Write("Nota 2: ");
            nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"A média entre {nota1} e {nota2} é {Media()}");
        }
    }
}
