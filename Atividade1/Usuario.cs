using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace Atividade1
{
    public class Usuario
    {
        private string nome;
        private string cpf;
        public string cpfUpdate  { get; set; }
        public string nomeUpdate { get; set; }
        public ICommand botaoUpdate { get;  set; }

        public ICommand botaoCancelar { get;  set; }


        public Usuario(string nome, string cpf)
        {
            this.nome = nome;
            this.cpf = cpf;

        }


        public string Nome { get { return nome; } set { nome = value; } }


        public string Cpf { get { return cpf; } set { cpf = value; } }
        
        
    }
}