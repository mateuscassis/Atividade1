using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Atividade1
{
    public class Usuario
    {
        String nome;
        int cpf;

        public Usuario()
        { 
        }

            public Usuario(String nome, int cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public void setCpf(int cpf)
        {
            this.cpf = cpf;
        }

        public String getNome()
        {
            return this.nome;
        }

        public int getCpf()
        {
            return this.cpf;
        }
    }
}