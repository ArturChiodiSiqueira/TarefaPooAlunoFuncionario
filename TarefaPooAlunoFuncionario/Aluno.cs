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
    internal class Aluno : Pessoa
    {
        String Registro;
        string DataMatricula;

        public Aluno(string nome, string dataNascimento, long cpf, string registro, string dataMatricula) : base(nome, dataNascimento, cpf)
        {
            Registro = registro;
            DataMatricula = dataMatricula;
        }

        public override string ToString()
        {
            return base.ToString() + "\nRegistro: " + Registro + "\nData de matricula: " + DataMatricula;
        }
    }
}
