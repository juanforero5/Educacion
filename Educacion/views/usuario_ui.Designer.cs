namespace Educacion.views
{
    partial class usuario_ui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtNom1 = new TextBox();
            txtNom2 = new TextBox();
            txtApe1 = new TextBox();
            txtApe2 = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtRol = new TextBox();
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 14F, FontStyle.Bold);
            label1.Location = new Point(22, 25);
            label1.Name = "label1";
            label1.Size = new Size(322, 40);
            label1.TabIndex = 0;
            label1.Text = "Gestión de usuarios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 65);
            label2.Name = "label2";
            label2.Size = new Size(204, 25);
            label2.TabIndex = 1;
            label2.Text = "Crear un usuario  nuevo:";
            // 
            // txtNom1
            // 
            txtNom1.Location = new Point(26, 144);
            txtNom1.Name = "txtNom1";
            txtNom1.PlaceholderText = "Primer nombre";
            txtNom1.Size = new Size(264, 31);
            txtNom1.TabIndex = 2;
            txtNom1.Tag = "";
            // 
            // txtNom2
            // 
            txtNom2.Location = new Point(26, 206);
            txtNom2.Name = "txtNom2";
            txtNom2.PlaceholderText = "Segundo nombre";
            txtNom2.Size = new Size(264, 31);
            txtNom2.TabIndex = 3;
            txtNom2.Tag = "";
            // 
            // txtApe1
            // 
            txtApe1.Location = new Point(356, 144);
            txtApe1.Name = "txtApe1";
            txtApe1.PlaceholderText = "Primer apellido";
            txtApe1.Size = new Size(264, 31);
            txtApe1.TabIndex = 4;
            txtApe1.Tag = "";
            // 
            // txtApe2
            // 
            txtApe2.Location = new Point(356, 206);
            txtApe2.Name = "txtApe2";
            txtApe2.PlaceholderText = "Segundo apellido";
            txtApe2.Size = new Size(264, 31);
            txtApe2.TabIndex = 5;
            txtApe2.Tag = "";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(26, 297);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Correo electrónico";
            txtEmail.Size = new Size(264, 31);
            txtEmail.TabIndex = 6;
            txtEmail.Tag = "";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(26, 382);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Contraseña";
            txtPassword.Size = new Size(264, 31);
            txtPassword.TabIndex = 8;
            txtPassword.Tag = "";
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtRol
            // 
            txtRol.Location = new Point(356, 297);
            txtRol.Name = "txtRol";
            txtRol.PlaceholderText = "Rol";
            txtRol.Size = new Size(264, 31);
            txtRol.TabIndex = 9;
            txtRol.Tag = "";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(508, 379);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(112, 34);
            btnRegistrar.TabIndex = 10;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // usuario_ui
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegistrar);
            Controls.Add(txtRol);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtApe2);
            Controls.Add(txtApe1);
            Controls.Add(txtNom2);
            Controls.Add(txtNom1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "usuario_ui";
            Text = "Gestión de usuarios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNom1;
        private TextBox txtNom2;
        private TextBox txtApe1;
        private TextBox txtApe2;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtRol;
        private Button btnRegistrar;
    }
}