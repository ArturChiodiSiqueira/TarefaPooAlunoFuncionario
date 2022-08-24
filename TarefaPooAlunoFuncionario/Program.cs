using System;
using System.Numerics;

namespace TarefaPooAlunoFuncionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno("Baratão", "09/11/1998", 99999, "55A2c", "24/08/2022");
            Console.WriteLine(aluno);

            Console.WriteLine();

            Funcionario funcionario = new Funcionario("Grande Pestana", "18/08/1917", 11111, "222 00000 3333333", 457978, "Hipinose");
            Console.WriteLine(funcionario);
        }
    }
}
