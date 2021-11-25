using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
    public class DadosUsuarios
    {
        public void testeValidaUsuario() {
            string nome = "Mateus cuel A";
            string cpf = "41971654809";

            Usuario usuario = new Usuario(nome, cpf);
            
            Assert.IsNotNull(usuario);
            Assert.IsTrue(usuario.Cpf == cpf);
            Assert.IsTrue(usuario.Nome == nome);
            Console.WriteLine("teste");
        }
    }

   }
