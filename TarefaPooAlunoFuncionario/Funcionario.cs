using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarefaPooAlunoFuncionario
{
    internal class Funcionario : Pessoa
    {
        String Pis;
        double Salario;
        String Setor;

        public Funcionario(string nome, string dataNascimento, long cpf, string pis, double salario, string setor) : base(nome, dataNascimento, cpf)
        {
            Pis = pis;
            Salario = salario;
            Setor = setor;
        }
        public override string ToString()
        {
            return base.ToString() + "\nPis: " + Pis + "\nSalario: " + Salario + "\nSetor: " + Setor;
        }
    }
}
