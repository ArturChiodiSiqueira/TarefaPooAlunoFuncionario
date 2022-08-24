using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TarefaPooAlunoFuncionario
{
    internal class Pessoa
    {
        String Nome;
        string DataNascimento;
        long Cpf;

        public Pessoa(string nome, string dataNascimento, long cpf)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Cpf = cpf;
        }

        public override string ToString()
        {
            return "Nome: " + Nome + "\nData de Nascimento: " + DataNascimento + "\nCPF: " + Cpf;
        }
    }
}
