using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
    public class DeletarUsuarioBd
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();

        public DeletarUsuarioBd(Usuario usuario)
        {
            cmd.CommandText = "delete from Usuarios WHERE cpf = @cpf";

            cmd.Parameters.AddWithValue("@cpf", usuario.Cpf);
            cmd.Connection = conexao.conectar();
            cmd.ExecuteReader();
            conexao.desconectar();
        }
    }
}
