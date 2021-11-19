using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
    public class CadastroUsuarioBd
    {
    
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();

        public CadastroUsuarioBd(Usuario usuario) {
            cmd.CommandText = "insert into Usuarios(id, nome, cpf) values (@id, @nome, @cpf)";

            cmd.Parameters.AddWithValue("@id", usuario.Id);
            cmd.Parameters.AddWithValue("@nome",usuario.Nome);
            cmd.Parameters.AddWithValue("@cpf", usuario.Cpf);

            cmd.Connection = conexao.conectar();
            cmd.ExecuteReader();
            conexao.desconectar();

        }
    }
}
