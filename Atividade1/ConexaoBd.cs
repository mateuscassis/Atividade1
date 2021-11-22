using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
    internal class ConexaoBd: DAO<Usuario>
    {
        private SqlConnection con;
        private SqlCommand cmd;

        public ConexaoBd()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=PC-KROCHS\SQLEXPRESS;Initial Catalog=Atividade1;Integrated Security=True";
            cmd = new SqlCommand();
            cmd.Connection = con;
        }

        public void cadastrarUsuario(Usuario usuario)
        {
            try
            {
                conectar();
                cmd.CommandText = "insert into Usuarios(id, nome, cpf) values (@id, @nome, @cpf)";
                cmd.Parameters.AddWithValue("@id", usuario.Id);
                cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                cmd.Parameters.AddWithValue("@cpf", usuario.Cpf);
                cmd.ExecuteReader();
                cmd.Parameters.Clear();
                desconectar();
            }
            catch (SqlException)
            {
                Console.WriteLine("Erro de banco");
            }
        }

        public void deletarUsuario(Usuario usuario)
        {
            try
            {
                cmd.CommandText = "delete from Usuarios WHERE cpf = @cpfDelete";
                cmd.Parameters.AddWithValue("@cpfDelete", usuario.Cpf);
                conectar();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                desconectar();
            }
            catch (SqlException)
            {
                Console.WriteLine("Erro de banco");
            }
        }

        public List<Usuario> viewUsuario()
        {
            List<Usuario> usuarios = new List<Usuario>();
            cmd.CommandText = "select * from Usuarios";
            conectar();
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                usuarios.Add(new Usuario()
                {
                    Id = rdr.GetInt32(0),
                    Nome = rdr[1].ToString(),
                    Cpf = rdr[2].ToString()
                });
            }
            rdr.Close();
            desconectar();
            return usuarios;
        }
           

        public void updateUsuario(Usuario usuario)
        {
            try
            {
                cmd.CommandText = "UPDATE Usuarios SET nome = @nomeUpdate, cpf = @cpfUpdate WHERE id = @idUpdate";
                cmd.Parameters.AddWithValue("@nomeUpdate", usuario.Nome);
                cmd.Parameters.AddWithValue("@cpfUpdate", usuario.Cpf);
                cmd.Parameters.AddWithValue("@idUpdate", usuario.Id);
                conectar();
                cmd.ExecuteReader();
                cmd.Parameters.Clear();
                desconectar();
            }
            catch (SqlException)
            {
                Console.WriteLine("Erro de banco");
            }
        }

        public void conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
        }

        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }
    }
}
