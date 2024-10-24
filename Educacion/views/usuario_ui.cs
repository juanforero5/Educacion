using MysqlBDM.controllers;
using MysqlBDM.models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Windows.Forms;

namespace Educacion.views
{
    public partial class usuario_ui : Form
    {
        private UsuarioController usuarioController;

        public usuario_ui()
        {
            InitializeComponent();
            usuarioController = new UsuarioController();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // objeto usuario para grabar en la bd
            Usuario nuevoUsuario = new Usuario
            {
                Nom1_usuario = txtNom1.Text,
                Nom2_usuario = txtNom2.Text,
                Ape1_usuario = txtApe1.Text,
                Ape2_usuario = txtApe2.Text,
                Email_usuario = txtEmail.Text,
                Rol_usuario = txtRol.Text,
                Password = txtPassword.Text
            };

            // crear registro en la bd
            usuarioController.AddUsuario(nuevoUsuario);
            MessageBox.Show("Usuario registrado correctamente.");


            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNom1.Clear();
            txtNom2.Clear();
            txtApe1.Clear();
            txtApe2.Clear();
            txtEmail.Clear();
            txtRol.Clear();
            txtPassword.Clear();
        }

        private void CargarUsuarios()
        {
            var usuarios = usuarioController.GetUsuarios();


        }

    }
}
