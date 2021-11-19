using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
    internal class UpdateUsuarioBd
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();

        public UpdateUsuarioBd(Usuario usuario)
        {
            cmd.CommandText = "UPDATE Usuarios SET nome = @nome, cpf = @cpfNovo WHERE id = @id";
            
            cmd.Parameters.AddWithValue("@nome", usuario.Nome);
            cmd.Parameters.AddWithValue("@cpfNovo", usuario.Cpf);
            cmd.Parameters.AddWithValue("@id", usuario.Id);
           

            cmd.Connection = conexao.conectar();
            cmd.ExecuteReader();
            conexao.desconectar();
        }
    }
}
