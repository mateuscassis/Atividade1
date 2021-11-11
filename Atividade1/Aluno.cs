using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Atividade1
{
    public class Aluno : Usuario
    {
        int matricula;
        public Aluno(string nome, int cpf, int matricula) : base(nome, cpf)
        {
            this.matricula = matricula;
        }

        public int getMatricula()
        {
            return this.matricula;

        }

        public void setMatricula(int matricula)
        {
            this.matricula = matricula;

        }
    }
}