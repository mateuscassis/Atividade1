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
            if (string.IsNullOrEmpty(nome))
               throw new Exception("Nome nao pode ser vazio");
            if (string.IsNullOrEmpty(cpf))
                throw new Exception("Cpf nao pode ser vazio");
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

        public bool validaCpf(string cpf) {

            string valor = cpf.Replace(".", "");
            valor = valor.Replace("-", "");

            if (valor.Length != 11)
            {
                return false;
            }
           
            bool igual = true;

            for (int i = 1; i < 11 && igual; i++)
            {
                if (valor[i] != valor[0])
                {
                    igual = false;
                }
            }

            if (igual || valor == "12345678909")
                return false;

            int[] numeros = new int[11];

            for (int i = 0; i < 11; i++)
                numeros[i] = int.Parse(valor[i].ToString());

            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += (10 - i) * numeros[i];

            int resultado = soma % 11;

            if (resultado == 1 || resultado == 0)
            {
                if (numeros[9] != 0)
                    return false;
            }
            else if (numeros[9] != 11 - resultado)
                return false;
            
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += (11 - i) * numeros[i];

            resultado = soma % 11;

            if (resultado == 1 || resultado == 0)
            {
                if (numeros[10] != 0)
                    return false;
            }
            else
                if (numeros[10] != 11 - resultado)
                return false;

            return true;
        }
        
        
    }
}