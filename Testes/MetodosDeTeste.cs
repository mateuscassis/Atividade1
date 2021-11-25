using Atividade1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Testes
{
    internal class MetodosDeTeste
    {
        public void testaUsuario()
        {
            string nome = "mateus cuel assis";
            string cpf = "41971654809";

            Usuario usuario1 = new Usuario(nome, cpf);

            Assert.IsNotNull(usuario1);
            Assert.IsTrue(pessoa.Cpf == cpf);
            Assert.IsTrue(pessoa.Nome == nome);
        }



    }
}
