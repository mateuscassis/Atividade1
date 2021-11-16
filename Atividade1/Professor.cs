using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Atividade1
{
    public class Professor : Usuario
    {
        string institucionalId;
        public Professor(string nome, string cpf, string institucionalId) : base(nome, cpf)
        {
            this.institucionalId = institucionalId;
        }

        public void setInstitucionalId(string InstitucionalId) { 
            this.institucionalId = InstitucionalId;
        }

        public string getInstitucionalId() { 
            return this.institucionalId;
        }
    }
}