using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Atividade1
{
    public class Professor : Usuario
    {
        int institucionalId;
        public Professor(string nome, int cpf, int institucionalId) : base(nome, cpf)
        {
            this.institucionalId = institucionalId;
        }

        public void setInstitucionalId(int InstitucionalId) { 
            this.institucionalId = InstitucionalId;
        }

        public int getInstitucionalId() { 
            return this.institucionalId;
        }
    }
}