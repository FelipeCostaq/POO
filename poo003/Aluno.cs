using System;

namespace poo003
{
    internal class Aluno
    {
        // Atributos
        public string nome;
        public double nota1, nota2;

        // Métodos
        public double Media()
        {
            return (nota1 + nota2) / 2;
        }

        public string Situação(double media)
        {
            return media >= 5 ? "Aprovado" : "Reprovado";
        }

        public void Mensagem()
        {
            Console.WriteLine($"{nome} sua média é {Media()} você foi {Situação(Media())}");
        }
    
    }

}
