﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Atividade1
{
    public class Usuario
    {
        private string nome;
        private string cpf;

        public Usuario()
        { 
        }

        public Usuario(string nome, string cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
        }


        public string Nome { get { return nome; } set { nome = value; } }


        public string Cpf { get { return cpf; } set { cpf = value; } }
     
    }
}