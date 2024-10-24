using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysqlBDM.models
{
    public class Usuario
    {
        public int Id_usuario { get; set; }
        public string Nom1_usuario { get; set; }
        public string Nom2_usuario { get; set; }
        public string Ape1_usuario { get; set; }
        public string Ape2_usuario { get; set; }
        public string Email_usuario { get; set; }
        public string Rol_usuario { get; set; }
        public string Password { get; set; }
        public DateTime? FechaCrea_usuario { get; set; }

        // constructor
        public Usuario() { }

        // guardar solo campos obligatorios
        public Usuario(string nom1, string email, string password)
        {
            Nom1_usuario = nom1;
            Email_usuario = email;
            Password = password;
        }

        // guardar todos los campos
        public Usuario(int id, string nom1, string nom2, string ape1, string ape2, string email, string rol, string password, DateTime? fechaCrea)
        {
            Id_usuario = id;
            Nom1_usuario = nom1;
            Nom2_usuario = nom2;
            Ape1_usuario = ape1;
            Ape2_usuario = ape2;
            Email_usuario = email;
            Rol_usuario = rol;
            Password = password;
            FechaCrea_usuario = fechaCrea;
        }
    }
}
