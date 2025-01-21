using System;

namespace poo003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno camilaAluno = new Aluno();
            camilaAluno.nome = "Camila";
            camilaAluno.nota1 = 7;
            camilaAluno.nota2 = 10;
            camilaAluno.Mensagem();
        }

    }
}
