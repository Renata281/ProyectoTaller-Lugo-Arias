namespace ProyectoTaller_Lugo_Arias.Views
{
    partial class ClientesView
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
            bBuscar = new Button();
            txtSearch = new TextBox();
            lMotorEmpleados = new Label();
            label1 = new Label();
            tabControl1 = new TabControl();
            tpTodos = new TabPage();
            bEliminar = new Button();
            bEditar = new Button();
            bNuevo = new Button();
            dataGridView3 = new DataGridView();
            lReservasTodas = new Label();
            tpActivos = new TabPage();
            dataGridView2 = new DataGridView();
            lReservasAct = new Label();
            tpInactivos = new TabPage();
            dataGridView1 = new DataGridView();
            lReservasFin = new Label();
            tpNuevoCliente = new TabPage();
            tbTelefono = new TextBox();
            tbEmail = new TextBox();
            label6 = new Label();
            label5 = new Label();
            tbDni = new TextBox();
            bGuardar = new Button();
            tbApellido = new TextBox();
            label3 = new Label();
            bCancelar = new Button();
            tbNombre = new TextBox();
            lFechaIngreso = new Label();
            label2 = new Label();
            lNuevaReserva = new Label();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tpTodos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tpActivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tpInactivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tpNuevoCliente.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(bBuscar);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(lMotorEmpleados);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(869, 69);
            panel1.TabIndex = 2;
            // 
            // bBuscar
            // 
            bBuscar.Location = new Point(599, 25);
            bBuscar.Name = "bBuscar";
            bBuscar.Size = new Size(75, 23);
            bBuscar.TabIndex = 4;
            bBuscar.Text = "Buscar";
            bBuscar.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.Control;
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Location = new Point(28, 29);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(534, 16);
            txtSearch.TabIndex = 2;
            // 
            // lMotorEmpleados
            // 
            lMotorEmpleados.AutoSize = true;
            lMotorEmpleados.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lMotorEmpleados.ForeColor = Color.DarkSlateGray;
            lMotorEmpleados.Location = new Point(28, 9);
            lMotorEmpleados.Name = "lMotorEmpleados";
            lMotorEmpleados.Size = new Size(99, 17);
            lMotorEmpleados.TabIndex = 1;
            lMotorEmpleados.Text = "Buscar Clientes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(312, 110);
            label1.Name = "label1";
            label1.Size = new Size(206, 32);
            label1.TabIndex = 3;
            label1.Text = "Registro Clientes";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpTodos);
            tabControl1.Controls.Add(tpActivos);
            tabControl1.Controls.Add(tpInactivos);
            tabControl1.Controls.Add(tpNuevoCliente);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 164);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(869, 384);
            tabControl1.TabIndex = 4;
            // 
            // tpTodos
            // 
            tpTodos.BackColor = SystemColors.Control;
            tpTodos.Controls.Add(bEliminar);
            tpTodos.Controls.Add(bEditar);
            tpTodos.Controls.Add(bNuevo);
            tpTodos.Controls.Add(dataGridView3);
            tpTodos.Controls.Add(lReservasTodas);
            tpTodos.Location = new Point(4, 30);
            tpTodos.Name = "tpTodos";
            tpTodos.Padding = new Padding(3);
            tpTodos.Size = new Size(861, 350);
            tpTodos.TabIndex = 0;
            tpTodos.Text = "Todos";
            // 
            // bEliminar
            // 
            bEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bEliminar.Location = new Point(740, 200);
            bEliminar.Name = "bEliminar";
            bEliminar.Size = new Size(99, 31);
            bEliminar.TabIndex = 11;
            bEliminar.Text = "Eliminar";
            bEliminar.UseVisualStyleBackColor = true;
            // 
            // bEditar
            // 
            bEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bEditar.Location = new Point(740, 141);
            bEditar.Name = "bEditar";
            bEditar.Size = new Size(99, 31);
            bEditar.TabIndex = 10;
            bEditar.Text = "Editar";
            bEditar.UseVisualStyleBackColor = true;
            // 
            // bNuevo
            // 
            bNuevo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bNuevo.Location = new Point(740, 79);
            bNuevo.Name = "bNuevo";
            bNuevo.Size = new Size(99, 31);
            bNuevo.TabIndex = 8;
            bNuevo.Text = "Nuevo";
            bNuevo.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView3.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(3, 79);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(718, 275);
            dataGridView3.TabIndex = 4;
            // 
            // lReservasTodas
            // 
            lReservasTodas.AutoSize = true;
            lReservasTodas.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lReservasTodas.ForeColor = Color.DarkSlateGray;
            lReservasTodas.Location = new Point(27, 28);
            lReservasTodas.Name = "lReservasTodas";
            lReservasTodas.Size = new Size(80, 25);
            lReservasTodas.TabIndex = 2;
            lReservasTodas.Text = "Clientes";
            // 
            // tpActivos
            // 
            tpActivos.BackColor = SystemColors.Control;
            tpActivos.Controls.Add(dataGridView2);
            tpActivos.Controls.Add(lReservasAct);
            tpActivos.ForeColor = Color.DarkSlateGray;
            tpActivos.Location = new Point(4, 30);
            tpActivos.Name = "tpActivos";
            tpActivos.Padding = new Padding(3);
            tpActivos.Size = new Size(861, 350);
            tpActivos.TabIndex = 1;
            tpActivos.Text = "Activos";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Bottom;
            dataGridView2.Location = new Point(3, 95);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(855, 252);
            dataGridView2.TabIndex = 5;
            // 
            // lReservasAct
            // 
            lReservasAct.AutoSize = true;
            lReservasAct.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lReservasAct.ForeColor = Color.DarkSlateGray;
            lReservasAct.Location = new Point(9, 28);
            lReservasAct.Name = "lReservasAct";
            lReservasAct.Size = new Size(148, 25);
            lReservasAct.TabIndex = 4;
            lReservasAct.Text = "Clientes Activos";
            // 
            // tpInactivos
            // 
            tpInactivos.BackColor = SystemColors.Control;
            tpInactivos.Controls.Add(dataGridView1);
            tpInactivos.Controls.Add(lReservasFin);
            tpInactivos.Location = new Point(4, 30);
            tpInactivos.Name = "tpInactivos";
            tpInactivos.Padding = new Padding(3);
            tpInactivos.Size = new Size(861, 350);
            tpInactivos.TabIndex = 2;
            tpInactivos.Text = "Inactivos";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(3, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(855, 252);
            dataGridView1.TabIndex = 5;
            // 
            // lReservasFin
            // 
            lReservasFin.AutoSize = true;
            lReservasFin.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lReservasFin.ForeColor = Color.DarkSlateGray;
            lReservasFin.Location = new Point(27, 27);
            lReservasFin.Name = "lReservasFin";
            lReservasFin.Size = new Size(162, 25);
            lReservasFin.TabIndex = 1;
            lReservasFin.Text = "Clientes Inactivos";
            // 
            // tpNuevoCliente
            // 
            tpNuevoCliente.BackColor = SystemColors.Control;
            tpNuevoCliente.Controls.Add(tbTelefono);
            tpNuevoCliente.Controls.Add(tbEmail);
            tpNuevoCliente.Controls.Add(label6);
            tpNuevoCliente.Controls.Add(label5);
            tpNuevoCliente.Controls.Add(tbDni);
            tpNuevoCliente.Controls.Add(bGuardar);
            tpNuevoCliente.Controls.Add(tbApellido);
            tpNuevoCliente.Controls.Add(label3);
            tpNuevoCliente.Controls.Add(bCancelar);
            tpNuevoCliente.Controls.Add(tbNombre);
            tpNuevoCliente.Controls.Add(lFechaIngreso);
            tpNuevoCliente.Controls.Add(label2);
            tpNuevoCliente.Controls.Add(lNuevaReserva);
            tpNuevoCliente.Location = new Point(4, 30);
            tpNuevoCliente.Name = "tpNuevoCliente";
            tpNuevoCliente.Padding = new Padding(3);
            tpNuevoCliente.Size = new Size(861, 350);
            tpNuevoCliente.TabIndex = 3;
            tpNuevoCliente.Text = "Nuevo Cliente";
            // 
            // tbTelefono
            // 
            tbTelefono.BackColor = SystemColors.Control;
            tbTelefono.Location = new Point(334, 165);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(254, 29);
            tbTelefono.TabIndex = 25;
            // 
            // tbEmail
            // 
            tbEmail.BackColor = SystemColors.Control;
            tbEmail.Location = new Point(334, 96);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(254, 29);
            tbEmail.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkSlateGray;
            label6.Location = new Point(334, 142);
            label6.Name = "label6";
            label6.Size = new Size(68, 20);
            label6.TabIndex = 23;
            label6.Text = "Teléfono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(334, 73);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 21;
            label5.Text = "Email";
            // 
            // tbDni
            // 
            tbDni.BackColor = SystemColors.Control;
            tbDni.Location = new Point(27, 227);
            tbDni.Name = "tbDni";
            tbDni.Size = new Size(254, 29);
            tbDni.TabIndex = 19;
            // 
            // bGuardar
            // 
            bGuardar.BackColor = Color.DarkSlateGray;
            bGuardar.FlatAppearance.BorderSize = 0;
            bGuardar.FlatStyle = FlatStyle.Flat;
            bGuardar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bGuardar.ForeColor = SystemColors.InactiveBorder;
            bGuardar.Location = new Point(281, 297);
            bGuardar.Name = "bGuardar";
            bGuardar.Size = new Size(99, 31);
            bGuardar.TabIndex = 18;
            bGuardar.Text = "Guardar";
            bGuardar.UseVisualStyleBackColor = false;
            // 
            // tbApellido
            // 
            tbApellido.BackColor = SystemColors.Control;
            tbApellido.Location = new Point(24, 165);
            tbApellido.Name = "tbApellido";
            tbApellido.Size = new Size(254, 29);
            tbApellido.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(30, 142);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 15;
            label3.Text = "Apellido";
            // 
            // bCancelar
            // 
            bCancelar.BackColor = SystemColors.InactiveCaption;
            bCancelar.FlatAppearance.BorderSize = 0;
            bCancelar.FlatStyle = FlatStyle.Flat;
            bCancelar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bCancelar.ForeColor = Color.DarkSlateGray;
            bCancelar.Location = new Point(426, 297);
            bCancelar.Name = "bCancelar";
            bCancelar.Size = new Size(99, 31);
            bCancelar.TabIndex = 11;
            bCancelar.Text = "Cancelar";
            bCancelar.UseVisualStyleBackColor = false;
            // 
            // tbNombre
            // 
            tbNombre.BackColor = SystemColors.Control;
            tbNombre.Location = new Point(24, 93);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(254, 29);
            tbNombre.TabIndex = 9;
            // 
            // lFechaIngreso
            // 
            lFechaIngreso.AutoSize = true;
            lFechaIngreso.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lFechaIngreso.ForeColor = Color.DarkSlateGray;
            lFechaIngreso.Location = new Point(30, 204);
            lFechaIngreso.Name = "lFechaIngreso";
            lFechaIngreso.Size = new Size(36, 20);
            lFechaIngreso.TabIndex = 2;
            lFechaIngreso.Text = "DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(27, 73);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre ";
            // 
            // lNuevaReserva
            // 
            lNuevaReserva.AutoSize = true;
            lNuevaReserva.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lNuevaReserva.ForeColor = Color.DarkSlateGray;
            lNuevaReserva.Location = new Point(30, 35);
            lNuevaReserva.Name = "lNuevaReserva";
            lNuevaReserva.Size = new Size(134, 25);
            lNuevaReserva.TabIndex = 0;
            lNuevaReserva.Text = "Nuevo Cliente";
            // 
            // ClientesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(869, 548);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "ClientesView";
            Text = "ClientesView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tpTodos.ResumeLayout(false);
            tpTodos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tpActivos.ResumeLayout(false);
            tpActivos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tpInactivos.ResumeLayout(false);
            tpInactivos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tpNuevoCliente.ResumeLayout(false);
            tpNuevoCliente.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtSearch;
        private Label lMotorEmpleados;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tpTodos;
        private DataGridView dataGridView3;
        private Label lReservasTodas;
        private TabPage tpActivos;
        private Label lReservasAct;
        private TabPage tpInactivos;
        private Label lReservasFin;
        private TabPage tpNuevoCliente;
        private Label label6;
        private Label label5;
        private TextBox tbDni;
        private Button bGuardar;
        private TextBox tbApellido;
        private Label label3;
        private Button bCancelar;
        private TextBox tbNombre;
        private Label lFechaIngreso;
        private Label label2;
        private Label lNuevaReserva;
        private TextBox tbTelefono;
        private TextBox tbEmail;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private Button bBuscar;
        private Button bNuevo;
        private Button bEditar;
        private Button bEliminar;
    }
}