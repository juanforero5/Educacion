using MySql.Data.MySqlClient;
using MysqlBDM.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysqlBDM.controllers
{
    public class UsuarioController
    {
        private readonly string connectionString = "server=localhost;database=proyecto;user=root;password=root;";

        public void AddUsuario(Usuario usuario)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO usuario (nom1_usuario, nom2_usuario, ape1_usuario, ape2_usuario, email_usuario, rol_usuario, password, fechaCrea_usuario) " +
                               "VALUES (@nom1, @nom2, @ape1, @ape2, @email, @rol, @password, @fechaCrea)";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nom1", usuario.Nom1_usuario);
                    command.Parameters.AddWithValue("@nom2", usuario.Nom2_usuario);
                    command.Parameters.AddWithValue("@ape1", usuario.Ape1_usuario);
                    command.Parameters.AddWithValue("@ape2", usuario.Ape2_usuario);
                    command.Parameters.AddWithValue("@email", usuario.Email_usuario);
                    command.Parameters.AddWithValue("@rol", usuario.Rol_usuario);
                    command.Parameters.AddWithValue("@password", usuario.Password);
                    command.Parameters.AddWithValue("@fechaCrea", DateTime.Now);

                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Usuario> GetUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM usuario";

                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Usuario usuario = new Usuario
                            {
                                Id_usuario = reader.GetInt32("id_usuario"),
                                Nom1_usuario = reader.GetString("nom1_usuario"),
                                Nom2_usuario = reader.IsDBNull(reader.GetOrdinal("nom2_usuario")) ? null : reader.GetString("nom2_usuario"),
                                Ape1_usuario = reader.IsDBNull(reader.GetOrdinal("ape1_usuario")) ? null : reader.GetString("ape1_usuario"),
                                Ape2_usuario = reader.IsDBNull(reader.GetOrdinal("ape2_usuario")) ? null : reader.GetString("ape2_usuario"),
                                Email_usuario = reader.GetString("email_usuario"),
                                Rol_usuario = reader.IsDBNull(reader.GetOrdinal("rol_usuario")) ? null : reader.GetString("rol_usuario"),
                                Password = reader.GetString("password"),
                                FechaCrea_usuario = reader.GetDateTime("fechaCrea_usuario")
                            };
                            usuarios.Add(usuario);
                        }
                    }
                }
            }
            return usuarios;
        }
    }
}
