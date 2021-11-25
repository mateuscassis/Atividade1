using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Atividade1
{
    public class ConexaoMySql : DAO
    {
        private MySqlConnection con;
        private MySqlCommand cmd;
        private MySqlDataReader rd;


        public ConexaoMySql(){
            con = new MySqlConnection();
            con.ConnectionString = "User ID = root; Password = Cecilia300567; Host = localhost; Port = 3306; Database = Atividade1;";
            cmd = new MySqlCommand();
            cmd.Connection = con;
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
        public void cadastrarUsuario(Usuario usuario)
        {
            try
            {
                conectar();
                cmd.CommandText = "insert into Usuario(id, nome, cpf) values (@id, @nome, @cpf)";
                cmd.Parameters.AddWithValue("@id", usuario.Id);
                cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                cmd.Parameters.AddWithValue("@cpf", usuario.Cpf);
                rd = cmd.ExecuteReader();
                cmd.Parameters.Clear();
                desconectar();
            }
            catch (Exception)
            {
                Console.WriteLine("Erro de banco");
            }

        }

        public void deletarUsuario(Usuario usuario)
        {
            try
            {
                cmd.CommandText = "delete from Usuario WHERE cpf = @cpfDelete";
                cmd.Parameters.AddWithValue("@cpfDelete", usuario.Cpf);
                conectar();
                rd = cmd.ExecuteReader();
                cmd.Parameters.Clear();
                desconectar();
            }
            catch (Exception)
            {
                Console.WriteLine("Erro de banco");
            }
        }

        public void updateUsuario(Usuario usuario)
        {
            try
            {
                cmd.CommandText = "UPDATE Usuario SET nome = @nomeUpdate, cpf = @cpfUpdate WHERE id = @idUpdate";
                cmd.Parameters.AddWithValue("@nomeUpdate", usuario.Nome);
                cmd.Parameters.AddWithValue("@cpfUpdate", usuario.Cpf);
                cmd.Parameters.AddWithValue("@idUpdate", usuario.Id);
                conectar();
                rd = cmd.ExecuteReader();
                cmd.Parameters.Clear();
                desconectar();
            }
            catch (Exception)
            {
                Console.WriteLine("Erro de banco");
            }
        }

        public List<Usuario> viewUsuario()
        {
            List<Usuario> usuarios = new List<Usuario>();
            cmd.CommandText = "select * from Usuario";
            conectar();
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                usuarios.Add(new Usuario()
                {
                    Id = rd.GetInt32(0),
                    Nome = rd[1].ToString(),
                    Cpf = rd[2].ToString()
                });
            }
            rd.Close();
            desconectar();
            return usuarios;
        }
    }
}
