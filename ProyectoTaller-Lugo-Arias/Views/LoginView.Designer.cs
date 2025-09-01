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
            lNombre = new Label();
            tbNombre = new TextBox();
            lContraseña = new Label();
            tbPass = new TextBox();
            bIniciarSesion = new Button();
            SuspendLayout();
            // 
            // lNombre
            // 
            lNombre.AutoSize = true;
            lNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lNombre.Location = new Point(26, 161);
            lNombre.Name = "lNombre";
            lNombre.Size = new Size(68, 21);
            lNombre.TabIndex = 0;
            lNombre.Text = "Nombre";
            lNombre.Click += label1_Click;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(26, 185);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(203, 23);
            tbNombre.TabIndex = 1;
            // 
            // lContraseña
            // 
            lContraseña.AutoSize = true;
            lContraseña.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lContraseña.Location = new Point(26, 223);
            lContraseña.Name = "lContraseña";
            lContraseña.Size = new Size(89, 21);
            lContraseña.TabIndex = 2;
            lContraseña.Text = "Contraseña";
            // 
            // tbPass
            // 
            tbPass.Location = new Point(26, 247);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(203, 23);
            tbPass.TabIndex = 3;
            // 
            // bIniciarSesion
            // 
            bIniciarSesion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bIniciarSesion.Location = new Point(26, 310);
            bIniciarSesion.Name = "bIniciarSesion";
            bIniciarSesion.Size = new Size(203, 35);
            bIniciarSesion.TabIndex = 4;
            bIniciarSesion.Text = "Iniciar sesión";
            bIniciarSesion.UseVisualStyleBackColor = true;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 386);
            Controls.Add(bIniciarSesion);
            Controls.Add(tbPass);
            Controls.Add(lContraseña);
            Controls.Add(tbNombre);
            Controls.Add(lNombre);
            Name = "LoginView";
            Text = "LoginView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lNombre;
        private TextBox tbNombre;
        private Label lContraseña;
        private TextBox tbPass;
        private Button bIniciarSesion;
    }
}