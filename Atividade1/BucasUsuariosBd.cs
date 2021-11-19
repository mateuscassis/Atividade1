using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
   
    public class BucasUsuariosBd
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();

        public BucasUsuariosBd()
        {
            cmd.CommandText = "Select * from Usuarios";

            cmd.Connection = conexao.conectar();
            cmd.ExecuteReader();
            conexao.desconectar();
        }

    }
}
