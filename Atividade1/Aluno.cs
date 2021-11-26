using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Atividade1
{
    public class Aluno : Usuario
    {
        int matricula;
        public Aluno(string nome, string cpf, int matricula) : base(nome, cpf)
        {
            this.matricula = matricula;
        }

        public int Matricula{ get { return matricula; } set { matricula = value; } }


    }
}