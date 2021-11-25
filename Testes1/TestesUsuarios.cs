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
            Usuario usuario2;

            var execaoObtida = Assert.Throws<Exception>(() => usuario2 = new Usuario(nome, cpf));
            var execaoEsperada = "Nome nao pode ser vazio";
            Assert.Equal(execaoEsperada, execaoObtida.Message);
        }
        
        [Fact]
        public void TestaCpfVazio()
        {

            string nome = "Mateus Cuel Assis";
            string cpf = "";
            Usuario usuario3;

            var execaoObtida = Assert.Throws<Exception>(() => usuario3 = new Usuario(nome, cpf));
            var execaoEsperada = "Cpf nao pode ser vazio";
            Assert.Equal(execaoEsperada, execaoObtida.Message);
        }

        [Fact]
        public void ValidaCpf() {

            string nome = "mateus cuel asis";
            string cpf = "777.777.777-77";
            Usuario usuario = new Usuario(nome,cpf);

            bool valorEsperado = false;
            Assert.Equal(valorEsperado,usuario.validaCpf(cpf));
        }


    }
}
