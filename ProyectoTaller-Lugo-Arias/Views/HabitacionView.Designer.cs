namespace ProyectoTaller_Lugo_Arias.Views
{
    partial class HabitacionView
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
            tpDisponible = new TabPage();
            dataGridView2 = new DataGridView();
            lReservasAct = new Label();
            tpOcupadas = new TabPage();
            dataGridView1 = new DataGridView();
            lReservasFin = new Label();
            tpNuevaHabt = new TabPage();
            cbEstado = new ComboBox();
            lEstado = new Label();
            cbPiso = new ComboBox();
            label6 = new Label();
            cbTipo = new ComboBox();
            label5 = new Label();
            tbDescripcion = new TextBox();
            tbPrecio = new TextBox();
            bGuardar = new Button();
            tbCamas = new TextBox();
            label3 = new Label();
            bCancelar = new Button();
            tbNro = new TextBox();
            lFechaSalida = new Label();
            lFechaIngreso = new Label();
            label2 = new Label();
            lNuevaReserva = new Label();
            tpMantenimiento = new TabPage();
            label4 = new Label();
            dataGridView4 = new DataGridView();
            lMaxPers = new Label();
            tbMaxPers = new TextBox();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tpTodos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tpDisponible.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tpOcupadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tpNuevaHabt.SuspendLayout();
            tpMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
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
            panel1.Size = new Size(966, 69);
            panel1.TabIndex = 1;
            // 
            // bBuscar
            // 
            bBuscar.Location = new Point(598, 25);
            bBuscar.Name = "bBuscar";
            bBuscar.Size = new Size(75, 23);
            bBuscar.TabIndex = 3;
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
            lMotorEmpleados.Size = new Size(117, 17);
            lMotorEmpleados.TabIndex = 1;
            lMotorEmpleados.Text = "Buscar Habitacion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(276, 84);
            label1.Name = "label1";
            label1.Size = new Size(264, 32);
            label1.TabIndex = 2;
            label1.Text = "Registro Habitaciones";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpTodos);
            tabControl1.Controls.Add(tpDisponible);
            tabControl1.Controls.Add(tpOcupadas);
            tabControl1.Controls.Add(tpNuevaHabt);
            tabControl1.Controls.Add(tpMantenimiento);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 136);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(966, 415);
            tabControl1.TabIndex = 3;
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
            tpTodos.Size = new Size(958, 381);
            tpTodos.TabIndex = 0;
            tpTodos.Text = "Todos";
            // 
            // bEliminar
            // 
            bEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bEliminar.Location = new Point(819, 213);
            bEliminar.Name = "bEliminar";
            bEliminar.Size = new Size(99, 31);
            bEliminar.TabIndex = 9;
            bEliminar.Text = "Eliminar";
            bEliminar.UseVisualStyleBackColor = true;
            // 
            // bEditar
            // 
            bEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bEditar.Location = new Point(819, 143);
            bEditar.Name = "bEditar";
            bEditar.Size = new Size(99, 31);
            bEditar.TabIndex = 8;
            bEditar.Text = "Editar";
            bEditar.UseVisualStyleBackColor = true;
            // 
            // bNuevo
            // 
            bNuevo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bNuevo.Location = new Point(819, 75);
            bNuevo.Name = "bNuevo";
            bNuevo.Size = new Size(99, 31);
            bNuevo.TabIndex = 6;
            bNuevo.Text = "Nuevo";
            bNuevo.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView3.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(3, 75);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(775, 303);
            dataGridView3.TabIndex = 4;
            // 
            // lReservasTodas
            // 
            lReservasTodas.AutoSize = true;
            lReservasTodas.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lReservasTodas.ForeColor = Color.DarkSlateGray;
            lReservasTodas.Location = new Point(24, 25);
            lReservasTodas.Name = "lReservasTodas";
            lReservasTodas.Size = new Size(123, 25);
            lReservasTodas.TabIndex = 2;
            lReservasTodas.Text = "Habitaciones";
            // 
            // tpDisponible
            // 
            tpDisponible.BackColor = SystemColors.Control;
            tpDisponible.Controls.Add(dataGridView2);
            tpDisponible.Controls.Add(lReservasAct);
            tpDisponible.ForeColor = Color.DarkSlateGray;
            tpDisponible.Location = new Point(4, 30);
            tpDisponible.Name = "tpDisponible";
            tpDisponible.Padding = new Padding(3);
            tpDisponible.Size = new Size(958, 381);
            tpDisponible.TabIndex = 1;
            tpDisponible.Text = "Disponible";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Bottom;
            dataGridView2.Location = new Point(3, 76);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(952, 302);
            dataGridView2.TabIndex = 5;
            // 
            // lReservasAct
            // 
            lReservasAct.AutoSize = true;
            lReservasAct.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lReservasAct.ForeColor = Color.DarkSlateGray;
            lReservasAct.Location = new Point(6, 25);
            lReservasAct.Name = "lReservasAct";
            lReservasAct.Size = new Size(227, 25);
            lReservasAct.TabIndex = 4;
            lReservasAct.Text = "Habitaciones Disponibles";
            // 
            // tpOcupadas
            // 
            tpOcupadas.BackColor = SystemColors.Control;
            tpOcupadas.Controls.Add(dataGridView1);
            tpOcupadas.Controls.Add(lReservasFin);
            tpOcupadas.Location = new Point(4, 30);
            tpOcupadas.Name = "tpOcupadas";
            tpOcupadas.Padding = new Padding(3);
            tpOcupadas.Size = new Size(958, 381);
            tpOcupadas.TabIndex = 2;
            tpOcupadas.Text = "Ocupadas";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(3, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(952, 309);
            dataGridView1.TabIndex = 6;
            // 
            // lReservasFin
            // 
            lReservasFin.AutoSize = true;
            lReservasFin.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lReservasFin.ForeColor = Color.DarkSlateGray;
            lReservasFin.Location = new Point(24, 24);
            lReservasFin.Name = "lReservasFin";
            lReservasFin.Size = new Size(212, 25);
            lReservasFin.TabIndex = 1;
            lReservasFin.Text = "Habitaciones Ocupadas";
            // 
            // tpNuevaHabt
            // 
            tpNuevaHabt.BackColor = SystemColors.Control;
            tpNuevaHabt.Controls.Add(tbMaxPers);
            tpNuevaHabt.Controls.Add(lMaxPers);
            tpNuevaHabt.Controls.Add(cbEstado);
            tpNuevaHabt.Controls.Add(lEstado);
            tpNuevaHabt.Controls.Add(cbPiso);
            tpNuevaHabt.Controls.Add(label6);
            tpNuevaHabt.Controls.Add(cbTipo);
            tpNuevaHabt.Controls.Add(label5);
            tpNuevaHabt.Controls.Add(tbDescripcion);
            tpNuevaHabt.Controls.Add(tbPrecio);
            tpNuevaHabt.Controls.Add(bGuardar);
            tpNuevaHabt.Controls.Add(tbCamas);
            tpNuevaHabt.Controls.Add(label3);
            tpNuevaHabt.Controls.Add(bCancelar);
            tpNuevaHabt.Controls.Add(tbNro);
            tpNuevaHabt.Controls.Add(lFechaSalida);
            tpNuevaHabt.Controls.Add(lFechaIngreso);
            tpNuevaHabt.Controls.Add(label2);
            tpNuevaHabt.Controls.Add(lNuevaReserva);
            tpNuevaHabt.Location = new Point(4, 30);
            tpNuevaHabt.Name = "tpNuevaHabt";
            tpNuevaHabt.Padding = new Padding(3);
            tpNuevaHabt.Size = new Size(958, 381);
            tpNuevaHabt.TabIndex = 3;
            tpNuevaHabt.Text = "Nueva Habitación";
            // 
            // cbEstado
            // 
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(317, 238);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(241, 29);
            cbEstado.TabIndex = 26;
            // 
            // lEstado
            // 
            lEstado.AutoSize = true;
            lEstado.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lEstado.ForeColor = Color.DarkSlateGray;
            lEstado.Location = new Point(317, 201);
            lEstado.Name = "lEstado";
            lEstado.Size = new Size(54, 20);
            lEstado.TabIndex = 25;
            lEstado.Text = "Estado";
            // 
            // cbPiso
            // 
            cbPiso.FormattingEnabled = true;
            cbPiso.Location = new Point(317, 159);
            cbPiso.Name = "cbPiso";
            cbPiso.Size = new Size(241, 29);
            cbPiso.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkSlateGray;
            label6.Location = new Point(317, 139);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 23;
            label6.Text = "Piso";
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(317, 93);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(241, 29);
            cbTipo.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(317, 70);
            label5.Name = "label5";
            label5.Size = new Size(115, 20);
            label5.TabIndex = 21;
            label5.Text = "Tipo habitación";
            // 
            // tbDescripcion
            // 
            tbDescripcion.BackColor = SystemColors.Control;
            tbDescripcion.Location = new Point(616, 172);
            tbDescripcion.Multiline = true;
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.Size = new Size(254, 95);
            tbDescripcion.TabIndex = 20;
            // 
            // tbPrecio
            // 
            tbPrecio.BackColor = SystemColors.Control;
            tbPrecio.Location = new Point(27, 238);
            tbPrecio.Name = "tbPrecio";
            tbPrecio.Size = new Size(254, 29);
            tbPrecio.TabIndex = 19;
            // 
            // bGuardar
            // 
            bGuardar.BackColor = Color.DarkSlateGray;
            bGuardar.FlatAppearance.BorderSize = 0;
            bGuardar.FlatStyle = FlatStyle.Flat;
            bGuardar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bGuardar.ForeColor = SystemColors.InactiveBorder;
            bGuardar.Location = new Point(308, 329);
            bGuardar.Name = "bGuardar";
            bGuardar.Size = new Size(99, 31);
            bGuardar.TabIndex = 18;
            bGuardar.Text = "Guardar";
            bGuardar.UseVisualStyleBackColor = false;
            // 
            // tbCamas
            // 
            tbCamas.BackColor = SystemColors.Control;
            tbCamas.Location = new Point(24, 159);
            tbCamas.Name = "tbCamas";
            tbCamas.Size = new Size(254, 29);
            tbCamas.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(27, 139);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 15;
            label3.Text = "Cantidad de camas";
            // 
            // bCancelar
            // 
            bCancelar.BackColor = SystemColors.InactiveCaption;
            bCancelar.FlatAppearance.BorderSize = 0;
            bCancelar.FlatStyle = FlatStyle.Flat;
            bCancelar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bCancelar.ForeColor = Color.DarkSlateGray;
            bCancelar.Location = new Point(437, 329);
            bCancelar.Name = "bCancelar";
            bCancelar.Size = new Size(99, 31);
            bCancelar.TabIndex = 11;
            bCancelar.Text = "Cancelar";
            bCancelar.UseVisualStyleBackColor = false;
            // 
            // tbNro
            // 
            tbNro.BackColor = SystemColors.Control;
            tbNro.Location = new Point(24, 93);
            tbNro.Name = "tbNro";
            tbNro.Size = new Size(254, 29);
            tbNro.TabIndex = 9;
            // 
            // lFechaSalida
            // 
            lFechaSalida.AutoSize = true;
            lFechaSalida.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lFechaSalida.ForeColor = Color.DarkSlateGray;
            lFechaSalida.Location = new Point(616, 139);
            lFechaSalida.Name = "lFechaSalida";
            lFechaSalida.Size = new Size(89, 20);
            lFechaSalida.TabIndex = 3;
            lFechaSalida.Text = "Descripción";
            // 
            // lFechaIngreso
            // 
            lFechaIngreso.AutoSize = true;
            lFechaIngreso.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lFechaIngreso.ForeColor = Color.DarkSlateGray;
            lFechaIngreso.Location = new Point(27, 201);
            lFechaIngreso.Name = "lFechaIngreso";
            lFechaIngreso.Size = new Size(112, 20);
            lFechaIngreso.TabIndex = 2;
            lFechaIngreso.Text = "Precio Unitario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(24, 70);
            label2.Name = "label2";
            label2.Size = new Size(144, 20);
            label2.TabIndex = 1;
            label2.Text = "Numero Habitación";
            // 
            // lNuevaReserva
            // 
            lNuevaReserva.AutoSize = true;
            lNuevaReserva.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lNuevaReserva.ForeColor = Color.DarkSlateGray;
            lNuevaReserva.Location = new Point(27, 32);
            lNuevaReserva.Name = "lNuevaReserva";
            lNuevaReserva.Size = new Size(166, 25);
            lNuevaReserva.TabIndex = 0;
            lNuevaReserva.Text = "Nueva Habitación";
            // 
            // tpMantenimiento
            // 
            tpMantenimiento.BackColor = SystemColors.Control;
            tpMantenimiento.Controls.Add(label4);
            tpMantenimiento.Controls.Add(dataGridView4);
            tpMantenimiento.Location = new Point(4, 30);
            tpMantenimiento.Name = "tpMantenimiento";
            tpMantenimiento.Size = new Size(958, 381);
            tpMantenimiento.TabIndex = 4;
            tpMantenimiento.Text = "Mantenimiento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(24, 26);
            label4.Name = "label4";
            label4.Size = new Size(287, 25);
            label4.TabIndex = 7;
            label4.Text = "Habitaciones en Mantenimiento";
            // 
            // dataGridView4
            // 
            dataGridView4.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView4.BorderStyle = BorderStyle.None;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Dock = DockStyle.Bottom;
            dataGridView4.Location = new Point(0, 74);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.Size = new Size(958, 307);
            dataGridView4.TabIndex = 6;
            // 
            // lMaxPers
            // 
            lMaxPers.AutoSize = true;
            lMaxPers.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lMaxPers.ForeColor = Color.DarkSlateGray;
            lMaxPers.Location = new Point(616, 70);
            lMaxPers.Name = "lMaxPers";
            lMaxPers.Size = new Size(151, 20);
            lMaxPers.TabIndex = 27;
            lMaxPers.Text = "Máximo de personas";
            // 
            // tbMaxPers
            // 
            tbMaxPers.BackColor = SystemColors.Control;
            tbMaxPers.Location = new Point(616, 93);
            tbMaxPers.Name = "tbMaxPers";
            tbMaxPers.Size = new Size(254, 29);
            tbMaxPers.TabIndex = 28;
            // 
            // HabitacionView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(966, 551);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "HabitacionView";
            Text = "HabitacionView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tpTodos.ResumeLayout(false);
            tpTodos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tpDisponible.ResumeLayout(false);
            tpDisponible.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tpOcupadas.ResumeLayout(false);
            tpOcupadas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tpNuevaHabt.ResumeLayout(false);
            tpNuevaHabt.PerformLayout();
            tpMantenimiento.ResumeLayout(false);
            tpMantenimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
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
        private TabPage tpDisponible;
        private Label lReservasAct;
        private TabPage tpOcupadas;
        private Label lReservasFin;
        private TabPage tpNuevaHabt;
        private Button bGuardar;
        private TextBox tbCamas;
        private Label label3;
        private Button bCancelar;
        private TextBox tbNro;
        private Label lFechaSalida;
        private Label lFechaIngreso;
        private Label label2;
        private Label lNuevaReserva;
        private DataGridView dataGridView2;
        private TabPage tpMantenimiento;
        private DataGridView dataGridView1;
        private Label label4;
        private DataGridView dataGridView4;
        private ComboBox cbTipo;
        private Label label5;
        private TextBox tbDescripcion;
        private TextBox tbPrecio;
        private ComboBox cbPiso;
        private Label label6;
        private ComboBox cbEstado;
        private Label lEstado;
        private Button bNuevo;
        private Button bEditar;
        private Button bEliminar;
        private Button bBuscar;
        private TextBox tbMaxPers;
        private Label lMaxPers;
    }
}