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
            textBox1 = new TextBox();
            lMotorEmpleados = new Label();
            lEmpleados = new Label();
            tabControl1 = new TabControl();
            tpTodos = new TabPage();
            dataGridView1 = new DataGridView();
            lTodosEmpleados = new Label();
            tpActivos = new TabPage();
            dgvEmpleadosAct = new DataGridView();
            lEmpleadoAct = new Label();
            tpInactivos = new TabPage();
            lEmpleado_In = new Label();
            dgvEmpleado_In = new DataGridView();
            tpNuevoCliente = new TabPage();
            bCancelar = new Button();
            bAgregar = new Button();
            comboBox1 = new ComboBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox2 = new TextBox();
            lCargo = new Label();
            lTelefono = new Label();
            lEmail = new Label();
            lDni = new Label();
            lApellido = new Label();
            lNombre = new Label();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tpTodos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tpActivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleadosAct).BeginInit();
            tpInactivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleado_In).BeginInit();
            tpNuevoCliente.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(lMotorEmpleados);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(796, 85);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(22, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(534, 16);
            textBox1.TabIndex = 1;
            // 
            // lMotorEmpleados
            // 
            lMotorEmpleados.AutoSize = true;
            lMotorEmpleados.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lMotorEmpleados.ForeColor = Color.DarkSlateGray;
            lMotorEmpleados.Location = new Point(22, 17);
            lMotorEmpleados.Name = "lMotorEmpleados";
            lMotorEmpleados.Size = new Size(112, 17);
            lMotorEmpleados.TabIndex = 0;
            lMotorEmpleados.Text = "Buscar Empleado";
            // 
            // lEmpleados
            // 
            lEmpleados.AutoSize = true;
            lEmpleados.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lEmpleados.ForeColor = Color.DarkSlateGray;
            lEmpleados.Location = new Point(326, 105);
            lEmpleados.Name = "lEmpleados";
            lEmpleados.Size = new Size(119, 30);
            lEmpleados.TabIndex = 0;
            lEmpleados.Text = "Empleados";
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
            tabControl1.Size = new Size(800, 471);
            tabControl1.TabIndex = 1;
            // 
            // tpTodos
            // 
            tpTodos.BackColor = SystemColors.Control;
            tpTodos.Controls.Add(dataGridView1);
            tpTodos.Controls.Add(lTodosEmpleados);
            tpTodos.Location = new Point(4, 24);
            tpTodos.Name = "tpTodos";
            tpTodos.Padding = new Padding(3);
            tpTodos.Size = new Size(792, 443);
            tpTodos.TabIndex = 0;
            tpTodos.Text = "Todos";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(3, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(786, 374);
            dataGridView1.TabIndex = 4;
            // 
            // lTodosEmpleados
            // 
            lTodosEmpleados.AutoSize = true;
            lTodosEmpleados.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lTodosEmpleados.Location = new Point(8, 24);
            lTodosEmpleados.Name = "lTodosEmpleados";
            lTodosEmpleados.Size = new Size(143, 21);
            lTodosEmpleados.TabIndex = 3;
            lTodosEmpleados.Text = "Lista de empleados";
            // 
            // tpActivos
            // 
            tpActivos.BackColor = SystemColors.Control;
            tpActivos.Controls.Add(dgvEmpleadosAct);
            tpActivos.Controls.Add(lEmpleadoAct);
            tpActivos.Location = new Point(4, 24);
            tpActivos.Name = "tpActivos";
            tpActivos.Padding = new Padding(3);
            tpActivos.Size = new Size(792, 443);
            tpActivos.TabIndex = 1;
            tpActivos.Text = "Activos";
            // 
            // dgvEmpleadosAct
            // 
            dgvEmpleadosAct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleadosAct.Dock = DockStyle.Bottom;
            dgvEmpleadosAct.Location = new Point(3, 65);
            dgvEmpleadosAct.Name = "dgvEmpleadosAct";
            dgvEmpleadosAct.Size = new Size(786, 375);
            dgvEmpleadosAct.TabIndex = 3;
            // 
            // lEmpleadoAct
            // 
            lEmpleadoAct.AutoSize = true;
            lEmpleadoAct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lEmpleadoAct.Location = new Point(8, 23);
            lEmpleadoAct.Name = "lEmpleadoAct";
            lEmpleadoAct.Size = new Size(138, 21);
            lEmpleadoAct.TabIndex = 2;
            lEmpleadoAct.Text = "Empleados activos";
            // 
            // tpInactivos
            // 
            tpInactivos.BackColor = SystemColors.Control;
            tpInactivos.Controls.Add(lEmpleado_In);
            tpInactivos.Controls.Add(dgvEmpleado_In);
            tpInactivos.Location = new Point(4, 24);
            tpInactivos.Name = "tpInactivos";
            tpInactivos.Padding = new Padding(3);
            tpInactivos.Size = new Size(792, 443);
            tpInactivos.TabIndex = 2;
            tpInactivos.Text = "Inactivos";
            // 
            // lEmpleado_In
            // 
            lEmpleado_In.AutoSize = true;
            lEmpleado_In.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lEmpleado_In.Location = new Point(8, 23);
            lEmpleado_In.Name = "lEmpleado_In";
            lEmpleado_In.Size = new Size(151, 21);
            lEmpleado_In.TabIndex = 1;
            lEmpleado_In.Text = "Empleados inactivos";
            // 
            // dgvEmpleado_In
            // 
            dgvEmpleado_In.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleado_In.Dock = DockStyle.Bottom;
            dgvEmpleado_In.Location = new Point(3, 69);
            dgvEmpleado_In.Name = "dgvEmpleado_In";
            dgvEmpleado_In.Size = new Size(786, 371);
            dgvEmpleado_In.TabIndex = 0;
            // 
            // tpNuevoCliente
            // 
            tpNuevoCliente.BackColor = SystemColors.Control;
            tpNuevoCliente.Controls.Add(bCancelar);
            tpNuevoCliente.Controls.Add(bAgregar);
            tpNuevoCliente.Controls.Add(comboBox1);
            tpNuevoCliente.Controls.Add(textBox8);
            tpNuevoCliente.Controls.Add(textBox7);
            tpNuevoCliente.Controls.Add(textBox6);
            tpNuevoCliente.Controls.Add(textBox5);
            tpNuevoCliente.Controls.Add(textBox2);
            tpNuevoCliente.Controls.Add(lCargo);
            tpNuevoCliente.Controls.Add(lTelefono);
            tpNuevoCliente.Controls.Add(lEmail);
            tpNuevoCliente.Controls.Add(lDni);
            tpNuevoCliente.Controls.Add(lApellido);
            tpNuevoCliente.Controls.Add(lNombre);
            tpNuevoCliente.Location = new Point(4, 24);
            tpNuevoCliente.Name = "tpNuevoCliente";
            tpNuevoCliente.Padding = new Padding(3);
            tpNuevoCliente.Size = new Size(792, 443);
            tpNuevoCliente.TabIndex = 3;
            tpNuevoCliente.Text = "Nuevo Empleado";
            // 
            // bCancelar
            // 
            bCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bCancelar.Location = new Point(415, 398);
            bCancelar.Name = "bCancelar";
            bCancelar.Size = new Size(78, 35);
            bCancelar.TabIndex = 15;
            bCancelar.Text = "Cancelar";
            bCancelar.UseVisualStyleBackColor = true;
            // 
            // bAgregar
            // 
            bAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bAgregar.Location = new Point(262, 398);
            bAgregar.Name = "bAgregar";
            bAgregar.Size = new Size(78, 35);
            bAgregar.TabIndex = 14;
            bAgregar.Text = "Agregar";
            bAgregar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(223, 352);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(319, 23);
            comboBox1.TabIndex = 13;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(223, 103);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(319, 23);
            textBox8.TabIndex = 12;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(223, 165);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(319, 23);
            textBox7.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(223, 230);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(319, 23);
            textBox6.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(223, 291);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(319, 23);
            textBox5.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(223, 39);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(319, 23);
            textBox2.TabIndex = 6;
            // 
            // lCargo
            // 
            lCargo.AutoSize = true;
            lCargo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lCargo.Location = new Point(223, 328);
            lCargo.Name = "lCargo";
            lCargo.Size = new Size(52, 21);
            lCargo.TabIndex = 5;
            lCargo.Text = "Cargo";
            // 
            // lTelefono
            // 
            lTelefono.AutoSize = true;
            lTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lTelefono.Location = new Point(223, 267);
            lTelefono.Name = "lTelefono";
            lTelefono.Size = new Size(68, 21);
            lTelefono.TabIndex = 4;
            lTelefono.Text = "Teléfono";
            // 
            // lEmail
            // 
            lEmail.AutoSize = true;
            lEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lEmail.Location = new Point(223, 206);
            lEmail.Name = "lEmail";
            lEmail.Size = new Size(48, 21);
            lEmail.TabIndex = 3;
            lEmail.Text = "Email";
            // 
            // lDni
            // 
            lDni.AutoSize = true;
            lDni.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lDni.Location = new Point(223, 141);
            lDni.Name = "lDni";
            lDni.Size = new Size(37, 21);
            lDni.TabIndex = 2;
            lDni.Text = "DNI";
            // 
            // lApellido
            // 
            lApellido.AutoSize = true;
            lApellido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lApellido.Location = new Point(223, 79);
            lApellido.Name = "lApellido";
            lApellido.Size = new Size(67, 21);
            lApellido.TabIndex = 1;
            lApellido.Text = "Apellido";
            // 
            // lNombre
            // 
            lNombre.AutoSize = true;
            lNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lNombre.Location = new Point(223, 15);
            lNombre.Name = "lNombre";
            lNombre.Size = new Size(68, 21);
            lNombre.TabIndex = 0;
            lNombre.Text = "Nombre";
            // 
            // EmpleadosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(796, 607);
            Controls.Add(tabControl1);
            Controls.Add(lEmpleados);
            Controls.Add(panel1);
            Name = "EmpleadosView";
            Text = "Empleados";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tpTodos.ResumeLayout(false);
            tpTodos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tpActivos.ResumeLayout(false);
            tpActivos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleadosAct).EndInit();
            tpInactivos.ResumeLayout(false);
            tpInactivos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleado_In).EndInit();
            tpNuevoCliente.ResumeLayout(false);
            tpNuevoCliente.PerformLayout();
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
        private Label lNombre;
        private Label lTelefono;
        private Label lEmail;
        private Label lDni;
        private Label lApellido;
        private Label lCargo;
        private Label lEmpleado_In;
        private DataGridView dgvEmpleado_In;
        private ComboBox comboBox1;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox2;
        private Label lEmpleadoAct;
        private DataGridView dgvEmpleadosAct;
        private DataGridView dataGridView1;
        private Label lTodosEmpleados;
        private Button bCancelar;
        private Button bAgregar;
    }
}