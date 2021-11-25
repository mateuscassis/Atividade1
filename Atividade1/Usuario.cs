using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace Atividade1
{
    public class Usuario
    {
        private static float id = 0;
        private string nome;
        private string cpf;

        public ICommand botaoUpdate { get;  set; }

        public Usuario() { }

        public Usuario(string nome, string cpf)
        {
            if (string.IsNullOrWhiteSpace(nome))
               throw new Exception();
            this.nome = nome;
            this.cpf = cpf;
            id += 1;
        }

        public float Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome { get { return nome; } set { nome = value; } }


        public string Cpf { get { return cpf; } set { cpf = value; } }
        
        
    }
}