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
            bBuscar = new Button();
            txtSearch = new TextBox();
            lMotorEmpleados = new Label();
            lEmpleados = new Label();
            tabControl1 = new TabControl();
            tpTodos = new TabPage();
            bCerrar = new Button();
            bEditar = new Button();
            bEliminar = new Button();
            bNuevo = new Button();
            dataGridView1 = new DataGridView();
            lTodosEmpleados = new Label();
            tpActivos = new TabPage();
            dgvEmpleadosAct = new DataGridView();
            lEmpleadoAct = new Label();
            tpInactivos = new TabPage();
            lEmpleado_In = new Label();
            dgvEmpleado_In = new DataGridView();
            tpNuevoEmpleado = new TabPage();
            tbPass = new TextBox();
            lPass = new Label();
            bCancelar = new Button();
            bGuardar = new Button();
            cbCargo = new ComboBox();
            tbApellido = new TextBox();
            tbDni = new TextBox();
            tbEmail = new TextBox();
            tbTelefono = new TextBox();
            tbNombre = new TextBox();
            lCargo = new Label();
            lTelefono = new Label();
            lEmail = new Label();
            lDni = new Label();
            lApellido = new Label();
            lNombre = new Label();
            dataGridView2 = new DataGridView();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tpTodos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tpActivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleadosAct).BeginInit();
            tpInactivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleado_In).BeginInit();
            tpNuevoEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(bBuscar);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(lMotorEmpleados);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(790, 72);
            panel1.TabIndex = 0;
            // 
            // bBuscar
            // 
            bBuscar.Location = new Point(573, 33);
            bBuscar.Name = "bBuscar";
            bBuscar.Size = new Size(75, 23);
            bBuscar.TabIndex = 2;
            bBuscar.Text = "Buscar";
            bBuscar.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.Control;
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Location = new Point(22, 37);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(533, 16);
            txtSearch.TabIndex = 1;
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
            lEmpleados.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lEmpleados.ForeColor = Color.DarkSlateGray;
            lEmpleados.Location = new Point(326, 86);
            lEmpleados.Name = "lEmpleados";
            lEmpleados.Size = new Size(138, 32);
            lEmpleados.TabIndex = 0;
            lEmpleados.Text = "Empleados";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpTodos);
            tabControl1.Controls.Add(tpActivos);
            tabControl1.Controls.Add(tpInactivos);
            tabControl1.Controls.Add(tpNuevoEmpleado);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 164);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(790, 418);
            tabControl1.TabIndex = 1;
            // 
            // tpTodos
            // 
            tpTodos.BackColor = SystemColors.Control;
            tpTodos.Controls.Add(bCerrar);
            tpTodos.Controls.Add(bEditar);
            tpTodos.Controls.Add(bEliminar);
            tpTodos.Controls.Add(bNuevo);
            tpTodos.Controls.Add(dataGridView1);
            tpTodos.Controls.Add(lTodosEmpleados);
            tpTodos.Location = new Point(4, 30);
            tpTodos.Name = "tpTodos";
            tpTodos.Padding = new Padding(3);
            tpTodos.Size = new Size(782, 384);
            tpTodos.TabIndex = 0;
            tpTodos.Text = "Todos";
            // 
            // bCerrar
            // 
            bCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bCerrar.Location = new Point(663, 446);
            bCerrar.Name = "bCerrar";
            bCerrar.Size = new Size(99, 31);
            bCerrar.TabIndex = 8;
            bCerrar.Text = "Cerrar";
            bCerrar.UseVisualStyleBackColor = true;
            // 
            // bEditar
            // 
            bEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bEditar.Location = new Point(663, 113);
            bEditar.Name = "bEditar";
            bEditar.Size = new Size(99, 31);
            bEditar.TabIndex = 7;
            bEditar.Text = "Editar";
            bEditar.UseVisualStyleBackColor = true;
            // 
            // bEliminar
            // 
            bEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bEliminar.Location = new Point(663, 171);
            bEliminar.Name = "bEliminar";
            bEliminar.Size = new Size(99, 31);
            bEliminar.TabIndex = 6;
            bEliminar.Text = "Eliminar";
            bEliminar.UseVisualStyleBackColor = true;
            // 
            // bNuevo
            // 
            bNuevo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bNuevo.Location = new Point(663, 58);
            bNuevo.Name = "bNuevo";
            bNuevo.Size = new Size(99, 31);
            bNuevo.TabIndex = 5;
            bNuevo.Text = "Nuevo";
            bNuevo.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(641, 488);
            dataGridView1.TabIndex = 4;
            // 
            // lTodosEmpleados
            // 
            lTodosEmpleados.AutoSize = true;
            lTodosEmpleados.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lTodosEmpleados.ForeColor = Color.DarkSlateGray;
            lTodosEmpleados.Location = new Point(8, 24);
            lTodosEmpleados.Name = "lTodosEmpleados";
            lTodosEmpleados.Size = new Size(175, 25);
            lTodosEmpleados.TabIndex = 3;
            lTodosEmpleados.Text = "Lista de empleados";
            // 
            // tpActivos
            // 
            tpActivos.BackColor = SystemColors.Control;
            tpActivos.Controls.Add(dataGridView2);
            tpActivos.Controls.Add(dgvEmpleadosAct);
            tpActivos.Controls.Add(lEmpleadoAct);
            tpActivos.Location = new Point(4, 30);
            tpActivos.Name = "tpActivos";
            tpActivos.Padding = new Padding(3);
            tpActivos.Size = new Size(782, 384);
            tpActivos.TabIndex = 1;
            tpActivos.Text = "Activos";
            // 
            // dgvEmpleadosAct
            // 
            dgvEmpleadosAct.BackgroundColor = SystemColors.InactiveCaption;
            dgvEmpleadosAct.BorderStyle = BorderStyle.None;
            dgvEmpleadosAct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleadosAct.Dock = DockStyle.Bottom;
            dgvEmpleadosAct.Location = new Point(3, -38);
            dgvEmpleadosAct.Name = "dgvEmpleadosAct";
            dgvEmpleadosAct.Size = new Size(776, 419);
            dgvEmpleadosAct.TabIndex = 3;
            // 
            // lEmpleadoAct
            // 
            lEmpleadoAct.AutoSize = true;
            lEmpleadoAct.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lEmpleadoAct.ForeColor = Color.DarkSlateGray;
            lEmpleadoAct.Location = new Point(8, 23);
            lEmpleadoAct.Name = "lEmpleadoAct";
            lEmpleadoAct.Size = new Size(170, 25);
            lEmpleadoAct.TabIndex = 2;
            lEmpleadoAct.Text = "Empleados activos";
            // 
            // tpInactivos
            // 
            tpInactivos.BackColor = SystemColors.Control;
            tpInactivos.Controls.Add(lEmpleado_In);
            tpInactivos.Controls.Add(dgvEmpleado_In);
            tpInactivos.Location = new Point(4, 30);
            tpInactivos.Name = "tpInactivos";
            tpInactivos.Padding = new Padding(3);
            tpInactivos.Size = new Size(782, 384);
            tpInactivos.TabIndex = 2;
            tpInactivos.Text = "Inactivos";
            // 
            // lEmpleado_In
            // 
            lEmpleado_In.AutoSize = true;
            lEmpleado_In.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lEmpleado_In.ForeColor = Color.DarkSlateGray;
            lEmpleado_In.Location = new Point(8, 23);
            lEmpleado_In.Name = "lEmpleado_In";
            lEmpleado_In.Size = new Size(186, 25);
            lEmpleado_In.TabIndex = 1;
            lEmpleado_In.Text = "Empleados inactivos";
            // 
            // dgvEmpleado_In
            // 
            dgvEmpleado_In.BackgroundColor = SystemColors.InactiveCaption;
            dgvEmpleado_In.BorderStyle = BorderStyle.None;
            dgvEmpleado_In.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleado_In.Dock = DockStyle.Bottom;
            dgvEmpleado_In.Location = new Point(3, -42);
            dgvEmpleado_In.Name = "dgvEmpleado_In";
            dgvEmpleado_In.Size = new Size(776, 423);
            dgvEmpleado_In.TabIndex = 0;
            // 
            // tpNuevoEmpleado
            // 
            tpNuevoEmpleado.BackColor = SystemColors.Control;
            tpNuevoEmpleado.Controls.Add(tbPass);
            tpNuevoEmpleado.Controls.Add(lPass);
            tpNuevoEmpleado.Controls.Add(bCancelar);
            tpNuevoEmpleado.Controls.Add(bGuardar);
            tpNuevoEmpleado.Controls.Add(cbCargo);
            tpNuevoEmpleado.Controls.Add(tbApellido);
            tpNuevoEmpleado.Controls.Add(tbDni);
            tpNuevoEmpleado.Controls.Add(tbEmail);
            tpNuevoEmpleado.Controls.Add(tbTelefono);
            tpNuevoEmpleado.Controls.Add(tbNombre);
            tpNuevoEmpleado.Controls.Add(lCargo);
            tpNuevoEmpleado.Controls.Add(lTelefono);
            tpNuevoEmpleado.Controls.Add(lEmail);
            tpNuevoEmpleado.Controls.Add(lDni);
            tpNuevoEmpleado.Controls.Add(lApellido);
            tpNuevoEmpleado.Controls.Add(lNombre);
            tpNuevoEmpleado.Location = new Point(4, 30);
            tpNuevoEmpleado.Name = "tpNuevoEmpleado";
            tpNuevoEmpleado.Padding = new Padding(3);
            tpNuevoEmpleado.Size = new Size(782, 384);
            tpNuevoEmpleado.TabIndex = 3;
            tpNuevoEmpleado.Text = "Nuevo Empleado";
            // 
            // tbPass
            // 
            tbPass.BackColor = SystemColors.Control;
            tbPass.Location = new Point(430, 230);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(319, 29);
            tbPass.TabIndex = 17;
            // 
            // lPass
            // 
            lPass.AutoSize = true;
            lPass.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lPass.ForeColor = Color.DarkSlateGray;
            lPass.Location = new Point(430, 199);
            lPass.Name = "lPass";
            lPass.Size = new Size(92, 21);
            lPass.TabIndex = 16;
            lPass.Text = "Contraseña";
            // 
            // bCancelar
            // 
            bCancelar.BackColor = SystemColors.InactiveCaption;
            bCancelar.FlatAppearance.BorderSize = 0;
            bCancelar.FlatStyle = FlatStyle.Flat;
            bCancelar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bCancelar.ForeColor = Color.DarkSlateGray;
            bCancelar.Location = new Point(636, 367);
            bCancelar.Name = "bCancelar";
            bCancelar.Size = new Size(103, 35);
            bCancelar.TabIndex = 15;
            bCancelar.Text = "Cancelar";
            bCancelar.UseVisualStyleBackColor = false;
            // 
            // bGuardar
            // 
            bGuardar.BackColor = Color.DarkSlateGray;
            bGuardar.FlatAppearance.BorderSize = 0;
            bGuardar.FlatStyle = FlatStyle.Flat;
            bGuardar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bGuardar.ForeColor = SystemColors.InactiveBorder;
            bGuardar.Location = new Point(511, 367);
            bGuardar.Name = "bGuardar";
            bGuardar.Size = new Size(100, 35);
            bGuardar.TabIndex = 14;
            bGuardar.Text = "Guardar";
            bGuardar.UseVisualStyleBackColor = false;
            // 
            // cbCargo
            // 
            cbCargo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbCargo.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbCargo.BackColor = SystemColors.Control;
            cbCargo.FormattingEnabled = true;
            cbCargo.Location = new Point(430, 68);
            cbCargo.Name = "cbCargo";
            cbCargo.Size = new Size(319, 29);
            cbCargo.TabIndex = 13;
            // 
            // tbApellido
            // 
            tbApellido.BackColor = SystemColors.Control;
            tbApellido.Location = new Point(55, 150);
            tbApellido.Name = "tbApellido";
            tbApellido.Size = new Size(319, 29);
            tbApellido.TabIndex = 12;
            // 
            // tbDni
            // 
            tbDni.BackColor = SystemColors.Control;
            tbDni.Location = new Point(52, 230);
            tbDni.Name = "tbDni";
            tbDni.Size = new Size(319, 29);
            tbDni.TabIndex = 11;
            // 
            // tbEmail
            // 
            tbEmail.BackColor = SystemColors.Control;
            tbEmail.Location = new Point(430, 150);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(319, 29);
            tbEmail.TabIndex = 10;
            // 
            // tbTelefono
            // 
            tbTelefono.BackColor = SystemColors.Control;
            tbTelefono.Location = new Point(55, 309);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(319, 29);
            tbTelefono.TabIndex = 9;
            // 
            // tbNombre
            // 
            tbNombre.BackColor = SystemColors.Control;
            tbNombre.Location = new Point(55, 68);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(319, 29);
            tbNombre.TabIndex = 6;
            // 
            // lCargo
            // 
            lCargo.AutoSize = true;
            lCargo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lCargo.ForeColor = Color.DarkSlateGray;
            lCargo.Location = new Point(430, 35);
            lCargo.Name = "lCargo";
            lCargo.Size = new Size(54, 21);
            lCargo.TabIndex = 5;
            lCargo.Text = "Cargo";
            // 
            // lTelefono
            // 
            lTelefono.AutoSize = true;
            lTelefono.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lTelefono.ForeColor = Color.DarkSlateGray;
            lTelefono.Location = new Point(53, 276);
            lTelefono.Name = "lTelefono";
            lTelefono.Size = new Size(74, 21);
            lTelefono.TabIndex = 4;
            lTelefono.Text = "Teléfono";
            // 
            // lEmail
            // 
            lEmail.AutoSize = true;
            lEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lEmail.ForeColor = Color.DarkSlateGray;
            lEmail.Location = new Point(430, 117);
            lEmail.Name = "lEmail";
            lEmail.Size = new Size(48, 21);
            lEmail.TabIndex = 3;
            lEmail.Text = "Email";
            // 
            // lDni
            // 
            lDni.AutoSize = true;
            lDni.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lDni.ForeColor = Color.DarkSlateGray;
            lDni.Location = new Point(55, 199);
            lDni.Name = "lDni";
            lDni.Size = new Size(38, 21);
            lDni.TabIndex = 2;
            lDni.Text = "DNI";
            // 
            // lApellido
            // 
            lApellido.AutoSize = true;
            lApellido.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lApellido.ForeColor = Color.DarkSlateGray;
            lApellido.Location = new Point(55, 117);
            lApellido.Name = "lApellido";
            lApellido.Size = new Size(72, 21);
            lApellido.TabIndex = 1;
            lApellido.Text = "Apellido";
            // 
            // lNombre
            // 
            lNombre.AutoSize = true;
            lNombre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lNombre.ForeColor = Color.DarkSlateGray;
            lNombre.Location = new Point(55, 35);
            lNombre.Name = "lNombre";
            lNombre.Size = new Size(71, 21);
            lNombre.TabIndex = 0;
            lNombre.Text = "Nombre";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(776, 0);
            dataGridView2.TabIndex = 4;
            // 
            // EmpleadosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(790, 582);
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
            tpNuevoEmpleado.ResumeLayout(false);
            tpNuevoEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lEmpleados;
        private TextBox txtSearch;
        private Label lMotorEmpleados;
        private TabControl tabControl1;
        private TabPage tpTodos;
        private TabPage tpActivos;
        private TabPage tpInactivos;
        private TabPage tpNuevoEmpleado;
        private Label lNombre;
        private Label lTelefono;
        private Label lEmail;
        private Label lDni;
        private Label lApellido;
        private Label lCargo;
        private Label lEmpleado_In;
        private DataGridView dgvEmpleado_In;
        private ComboBox cbCargo;
        private TextBox tbApellido;
        private TextBox tbDni;
        private TextBox tbEmail;
        private TextBox tbTelefono;
        private TextBox tbNombre;
        private Label lEmpleadoAct;
        private DataGridView dgvEmpleadosAct;
        private DataGridView dataGridView1;
        private Label lTodosEmpleados;
        private Button bCancelar;
        private Button bGuardar;
        private Button bBuscar;
        private Button button1;
        private Button button2;
        private Button bNuevo;
        private Button bEditar;
        private Button bEliminar;
        private Label lPass;
        private TextBox tbPass;
        private Button bCerrar;
        private DataGridView dataGridView2;
    }
}