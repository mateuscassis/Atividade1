using Atividade1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Testes1
{
    public class TestesUsuarios
    {
        [Fact]
        public void TestaUsuario() {
            // Definindo cenario: Arrange
            string nome = "mateus cuel assis";
            string cpf = "41971654809";
            //Acao: Act
            Usuario usuario1 = new Usuario(nome, cpf);
            //Teste do Cenario : Assert
            Assert.True(usuario1.Nome == nome);
            Assert.True(usuario1.Cpf == cpf);

        }

        [Fact]
        public void TestaNomeVazio() {
            string nome = "";
            string cpf = "41971654809";

            Usuario usuario2 = new Usuario(nome, cpf);

            Assert.NotEmpty(usuario2.Nome);
        }
    }
}
