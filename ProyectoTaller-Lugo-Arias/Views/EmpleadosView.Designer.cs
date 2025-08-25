namespace ProyectoTaller_Lugo_Arias.Views
{
    partial class EmpleadosView
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
            panel1 = new Panel();
            lEmpleados = new Label();
            lMotorEmpleados = new Label();
            textBox1 = new TextBox();
            tabControl1 = new TabControl();
            tpTodos = new TabPage();
            tpActivos = new TabPage();
            tpInactivos = new TabPage();
            tpNuevoCliente = new TabPage();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(lMotorEmpleados);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 85);
            panel1.TabIndex = 0;
            // 
            // lEmpleados
            // 
            lEmpleados.AutoSize = true;
            lEmpleados.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lEmpleados.Location = new Point(326, 105);
            lEmpleados.Name = "lEmpleados";
            lEmpleados.Size = new Size(114, 30);
            lEmpleados.TabIndex = 0;
            lEmpleados.Text = "Empleados";
            // 
            // lMotorEmpleados
            // 
            lMotorEmpleados.AutoSize = true;
            lMotorEmpleados.Location = new Point(12, 19);
            lMotorEmpleados.Name = "lMotorEmpleados";
            lMotorEmpleados.Size = new Size(98, 15);
            lMotorEmpleados.TabIndex = 0;
            lMotorEmpleados.Text = "Buscar Empleado";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(534, 23);
            textBox1.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpTodos);
            tabControl1.Controls.Add(tpActivos);
            tabControl1.Controls.Add(tpInactivos);
            tabControl1.Controls.Add(tpNuevoCliente);
            tabControl1.Location = new Point(0, 138);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 149);
            tabControl1.TabIndex = 1;
            // 
            // tpTodos
            // 
            tpTodos.Location = new Point(4, 24);
            tpTodos.Name = "tpTodos";
            tpTodos.Padding = new Padding(3);
            tpTodos.Size = new Size(792, 121);
            tpTodos.TabIndex = 0;
            tpTodos.Text = "Todos";
            tpTodos.UseVisualStyleBackColor = true;
            // 
            // tpActivos
            // 
            tpActivos.Location = new Point(4, 24);
            tpActivos.Name = "tpActivos";
            tpActivos.Padding = new Padding(3);
            tpActivos.Size = new Size(792, 121);
            tpActivos.TabIndex = 1;
            tpActivos.Text = "Activos";
            tpActivos.UseVisualStyleBackColor = true;
            // 
            // tpInactivos
            // 
            tpInactivos.Location = new Point(4, 24);
            tpInactivos.Name = "tpInactivos";
            tpInactivos.Padding = new Padding(3);
            tpInactivos.Size = new Size(792, 121);
            tpInactivos.TabIndex = 2;
            tpInactivos.Text = "Inactivos";
            tpInactivos.UseVisualStyleBackColor = true;
            // 
            // tpNuevoCliente
            // 
            tpNuevoCliente.Location = new Point(4, 24);
            tpNuevoCliente.Name = "tpNuevoCliente";
            tpNuevoCliente.Padding = new Padding(3);
            tpNuevoCliente.Size = new Size(792, 121);
            tpNuevoCliente.TabIndex = 3;
            tpNuevoCliente.Text = "Nuevo Cliente";
            tpNuevoCliente.UseVisualStyleBackColor = true;
            // 
            // EmpleadosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(lEmpleados);
            Controls.Add(panel1);
            Name = "EmpleadosView";
            Text = "Empleados";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lEmpleados;
        private TextBox textBox1;
        private Label lMotorEmpleados;
        private TabControl tabControl1;
        private TabPage tpTodos;
        private TabPage tpActivos;
        private TabPage tpInactivos;
        private TabPage tpNuevoCliente;
    }
}