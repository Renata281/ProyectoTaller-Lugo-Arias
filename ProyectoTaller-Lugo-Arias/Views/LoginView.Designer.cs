namespace ProyectoTaller_Lugo_Arias.Views
{
    partial class LoginView
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
            lCorreo = new Label();
            lPass = new Label();
            tbCorreo = new TextBox();
            tbPass = new TextBox();
            bLogin = new Button();
            SuspendLayout();
            // 
            // lCorreo
            // 
            lCorreo.AutoSize = true;
            lCorreo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lCorreo.ForeColor = Color.DarkSlateGray;
            lCorreo.Location = new Point(25, 181);
            lCorreo.Name = "lCorreo";
            lCorreo.Size = new Size(70, 25);
            lCorreo.TabIndex = 0;
            lCorreo.Text = "Correo";
            // 
            // lPass
            // 
            lPass.AutoSize = true;
            lPass.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lPass.ForeColor = Color.DarkSlateGray;
            lPass.Location = new Point(25, 250);
            lPass.Name = "lPass";
            lPass.Size = new Size(109, 25);
            lPass.TabIndex = 1;
            lPass.Text = "Contraseña";
            // 
            // tbCorreo
            // 
            tbCorreo.BackColor = SystemColors.InactiveBorder;
            tbCorreo.Location = new Point(25, 209);
            tbCorreo.Name = "tbCorreo";
            tbCorreo.Size = new Size(211, 23);
            tbCorreo.TabIndex = 2;
            // 
            // tbPass
            // 
            tbPass.BackColor = SystemColors.InactiveBorder;
            tbPass.Location = new Point(25, 278);
            tbPass.Name = "tbPass";
            tbPass.PasswordChar = '*';
            tbPass.Size = new Size(211, 23);
            tbPass.TabIndex = 3;
            // 
            // bLogin
            // 
            bLogin.BackColor = Color.DarkSlateGray;
            bLogin.FlatStyle = FlatStyle.Flat;
            bLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bLogin.ForeColor = SystemColors.InactiveCaption;
            bLogin.Location = new Point(60, 338);
            bLogin.Name = "bLogin";
            bLogin.Size = new Size(131, 34);
            bLogin.TabIndex = 4;
            bLogin.Text = "Iniciar Sesión";
            bLogin.UseVisualStyleBackColor = false;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(263, 450);
            Controls.Add(bLogin);
            Controls.Add(tbPass);
            Controls.Add(tbCorreo);
            Controls.Add(lPass);
            Controls.Add(lCorreo);
            Name = "LoginView";
            Text = "LoginView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lCorreo;
        private Label lPass;
        private TextBox tbCorreo;
        private TextBox tbPass;
        private Button bLogin;
    }
}