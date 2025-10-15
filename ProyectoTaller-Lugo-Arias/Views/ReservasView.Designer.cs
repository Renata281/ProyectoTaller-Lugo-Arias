namespace ProyectoTaller_Lugo_Arias.Views
{
    partial class ReservasView
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
            lReservas = new Label();
            tabControl1 = new TabControl();
            tpTodos = new TabPage();
            bEliminar = new Button();
            bEditar = new Button();
            bNuevo = new Button();
            dgvTodos = new DataGridView();
            lReservasTodas = new Label();
            tpActivos = new TabPage();
            lReservasAct = new Label();
            dgvActivos = new DataGridView();
            tpFinalizados = new TabPage();
            dgvFinalizadas = new DataGridView();
            lReservasFin = new Label();
            tpNuevaReserva = new TabPage();
            cbTipoHab = new ComboBox();
            lTipoHabt = new Label();
            bConfirmar = new Button();
            panel2 = new Panel();
            cbFPago = new ComboBox();
            lMetodoPago = new Label();
            tbMonto = new TextBox();
            lMontoTotal = new Label();
            tbCantPers = new TextBox();
            label3 = new Label();
            bCancelar = new Button();
            tbCliente = new TextBox();
            cbHabitacion = new ComboBox();
            dtFechaSalida = new DateTimePicker();
            dtFechaIngreso = new DateTimePicker();
            label5 = new Label();
            lFechaSalida = new Label();
            lFechaIngreso = new Label();
            label2 = new Label();
            lNuevaReserva = new Label();
            tpPendientes = new TabPage();
            dgvPendientes = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tpTodos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTodos).BeginInit();
            tpActivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActivos).BeginInit();
            tpFinalizados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFinalizadas).BeginInit();
            tpNuevaReserva.SuspendLayout();
            panel2.SuspendLayout();
            tpPendientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPendientes).BeginInit();
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
            panel1.Size = new Size(790, 69);
            panel1.TabIndex = 0;
            // 
            // bBuscar
            // 
            bBuscar.Location = new Point(568, 25);
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
            lMotorEmpleados.Size = new Size(100, 17);
            lMotorEmpleados.TabIndex = 1;
            lMotorEmpleados.Text = "Buscar Reserva";
            // 
            // lReservas
            // 
            lReservas.AutoSize = true;
            lReservas.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lReservas.ForeColor = Color.DarkSlateGray;
            lReservas.Location = new Point(330, 72);
            lReservas.Name = "lReservas";
            lReservas.Size = new Size(114, 32);
            lReservas.TabIndex = 0;
            lReservas.Text = "Reservas";
            lReservas.TextAlign = ContentAlignment.TopCenter;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tpTodos);
            tabControl1.Controls.Add(tpActivos);
            tabControl1.Controls.Add(tpFinalizados);
            tabControl1.Controls.Add(tpNuevaReserva);
            tabControl1.Controls.Add(tpPendientes);
            tabControl1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 123);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(785, 496);
            tabControl1.TabIndex = 1;
            // 
            // tpTodos
            // 
            tpTodos.BackColor = SystemColors.Control;
            tpTodos.Controls.Add(bEliminar);
            tpTodos.Controls.Add(bEditar);
            tpTodos.Controls.Add(bNuevo);
            tpTodos.Controls.Add(dgvTodos);
            tpTodos.Controls.Add(lReservasTodas);
            tpTodos.Location = new Point(4, 30);
            tpTodos.Name = "tpTodos";
            tpTodos.Padding = new Padding(3);
            tpTodos.Size = new Size(777, 462);
            tpTodos.TabIndex = 0;
            tpTodos.Text = "Todos";
            // 
            // bEliminar
            // 
            bEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bEliminar.Location = new Point(662, 212);
            bEliminar.Name = "bEliminar";
            bEliminar.Size = new Size(99, 31);
            bEliminar.TabIndex = 9;
            bEliminar.Text = "Eliminar";
            bEliminar.UseVisualStyleBackColor = true;
            // 
            // bEditar
            // 
            bEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bEditar.Location = new Point(662, 143);
            bEditar.Name = "bEditar";
            bEditar.Size = new Size(99, 31);
            bEditar.TabIndex = 8;
            bEditar.Text = "Editar";
            bEditar.UseVisualStyleBackColor = true;
            // 
            // bNuevo
            // 
            bNuevo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bNuevo.Location = new Point(662, 70);
            bNuevo.Name = "bNuevo";
            bNuevo.Size = new Size(99, 31);
            bNuevo.TabIndex = 6;
            bNuevo.Text = "Nuevo";
            bNuevo.UseVisualStyleBackColor = true;
            // 
            // dgvTodos
            // 
            dgvTodos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTodos.BackgroundColor = SystemColors.InactiveCaption;
            dgvTodos.BorderStyle = BorderStyle.None;
            dgvTodos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTodos.Location = new Point(3, 70);
            dgvTodos.Name = "dgvTodos";
            dgvTodos.Size = new Size(636, 375);
            dgvTodos.TabIndex = 4;
            // 
            // lReservasTodas
            // 
            lReservasTodas.AutoSize = true;
            lReservasTodas.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lReservasTodas.ForeColor = Color.DarkSlateGray;
            lReservasTodas.Location = new Point(37, 24);
            lReservasTodas.Name = "lReservasTodas";
            lReservasTodas.Size = new Size(87, 25);
            lReservasTodas.TabIndex = 2;
            lReservasTodas.Text = "Reservas";
            // 
            // tpActivos
            // 
            tpActivos.BackColor = SystemColors.Control;
            tpActivos.Controls.Add(lReservasAct);
            tpActivos.Controls.Add(dgvActivos);
            tpActivos.ForeColor = Color.DarkSlateGray;
            tpActivos.Location = new Point(4, 30);
            tpActivos.Name = "tpActivos";
            tpActivos.Padding = new Padding(3);
            tpActivos.Size = new Size(777, 462);
            tpActivos.TabIndex = 1;
            tpActivos.Text = "Activos";
            // 
            // lReservasAct
            // 
            lReservasAct.AutoSize = true;
            lReservasAct.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lReservasAct.ForeColor = Color.DarkSlateGray;
            lReservasAct.Location = new Point(42, 29);
            lReservasAct.Name = "lReservasAct";
            lReservasAct.Size = new Size(154, 25);
            lReservasAct.TabIndex = 4;
            lReservasAct.Text = "Reservas Activas";
            // 
            // dgvActivos
            // 
            dgvActivos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvActivos.BackgroundColor = SystemColors.InactiveCaption;
            dgvActivos.BorderStyle = BorderStyle.None;
            dgvActivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActivos.Location = new Point(3, 71);
            dgvActivos.Name = "dgvActivos";
            dgvActivos.Size = new Size(771, 400);
            dgvActivos.TabIndex = 3;
            // 
            // tpFinalizados
            // 
            tpFinalizados.BackColor = SystemColors.Control;
            tpFinalizados.Controls.Add(dgvFinalizadas);
            tpFinalizados.Controls.Add(lReservasFin);
            tpFinalizados.Location = new Point(4, 30);
            tpFinalizados.Name = "tpFinalizados";
            tpFinalizados.Padding = new Padding(3);
            tpFinalizados.Size = new Size(777, 462);
            tpFinalizados.TabIndex = 2;
            tpFinalizados.Text = "Finalizados";
            // 
            // dgvFinalizadas
            // 
            dgvFinalizadas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvFinalizadas.BackgroundColor = SystemColors.InactiveCaption;
            dgvFinalizadas.BorderStyle = BorderStyle.None;
            dgvFinalizadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFinalizadas.Location = new Point(3, 74);
            dgvFinalizadas.Name = "dgvFinalizadas";
            dgvFinalizadas.Size = new Size(771, 325);
            dgvFinalizadas.TabIndex = 2;
            // 
            // lReservasFin
            // 
            lReservasFin.AutoSize = true;
            lReservasFin.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lReservasFin.ForeColor = Color.DarkSlateGray;
            lReservasFin.Location = new Point(44, 28);
            lReservasFin.Name = "lReservasFin";
            lReservasFin.Size = new Size(186, 25);
            lReservasFin.TabIndex = 1;
            lReservasFin.Text = "Reservas Finalizadas";
            // 
            // tpNuevaReserva
            // 
            tpNuevaReserva.BackColor = SystemColors.Control;
            tpNuevaReserva.Controls.Add(cbTipoHab);
            tpNuevaReserva.Controls.Add(lTipoHabt);
            tpNuevaReserva.Controls.Add(bConfirmar);
            tpNuevaReserva.Controls.Add(panel2);
            tpNuevaReserva.Controls.Add(tbCantPers);
            tpNuevaReserva.Controls.Add(label3);
            tpNuevaReserva.Controls.Add(bCancelar);
            tpNuevaReserva.Controls.Add(tbCliente);
            tpNuevaReserva.Controls.Add(cbHabitacion);
            tpNuevaReserva.Controls.Add(dtFechaSalida);
            tpNuevaReserva.Controls.Add(dtFechaIngreso);
            tpNuevaReserva.Controls.Add(label5);
            tpNuevaReserva.Controls.Add(lFechaSalida);
            tpNuevaReserva.Controls.Add(lFechaIngreso);
            tpNuevaReserva.Controls.Add(label2);
            tpNuevaReserva.Controls.Add(lNuevaReserva);
            tpNuevaReserva.Location = new Point(4, 30);
            tpNuevaReserva.Name = "tpNuevaReserva";
            tpNuevaReserva.Padding = new Padding(3);
            tpNuevaReserva.Size = new Size(777, 462);
            tpNuevaReserva.TabIndex = 3;
            tpNuevaReserva.Text = "Nueva Reserva";
            // 
            // cbTipoHab
            // 
            cbTipoHab.BackColor = SystemColors.Control;
            cbTipoHab.FormattingEnabled = true;
            cbTipoHab.Location = new Point(24, 360);
            cbTipoHab.Name = "cbTipoHab";
            cbTipoHab.Size = new Size(254, 29);
            cbTipoHab.TabIndex = 20;
            // 
            // lTipoHabt
            // 
            lTipoHabt.AutoSize = true;
            lTipoHabt.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lTipoHabt.ForeColor = Color.DarkSlateGray;
            lTipoHabt.Location = new Point(24, 337);
            lTipoHabt.Name = "lTipoHabt";
            lTipoHabt.Size = new Size(115, 20);
            lTipoHabt.TabIndex = 19;
            lTipoHabt.Text = "Tipo habitación";
            // 
            // bConfirmar
            // 
            bConfirmar.BackColor = Color.DarkSlateGray;
            bConfirmar.FlatAppearance.BorderSize = 0;
            bConfirmar.FlatStyle = FlatStyle.Flat;
            bConfirmar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bConfirmar.ForeColor = SystemColors.InactiveBorder;
            bConfirmar.Location = new Point(482, 409);
            bConfirmar.Name = "bConfirmar";
            bConfirmar.Size = new Size(99, 31);
            bConfirmar.TabIndex = 18;
            bConfirmar.Text = "Confirmar";
            bConfirmar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveCaption;
            panel2.Controls.Add(cbFPago);
            panel2.Controls.Add(lMetodoPago);
            panel2.Controls.Add(tbMonto);
            panel2.Controls.Add(lMontoTotal);
            panel2.Location = new Point(424, 159);
            panel2.Name = "panel2";
            panel2.Size = new Size(298, 187);
            panel2.TabIndex = 17;
            // 
            // cbFPago
            // 
            cbFPago.BackColor = SystemColors.Control;
            cbFPago.FormattingEnabled = true;
            cbFPago.Location = new Point(19, 122);
            cbFPago.Name = "cbFPago";
            cbFPago.Size = new Size(263, 29);
            cbFPago.TabIndex = 13;
            // 
            // lMetodoPago
            // 
            lMetodoPago.AutoSize = true;
            lMetodoPago.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lMetodoPago.ForeColor = Color.DarkSlateGray;
            lMetodoPago.Location = new Point(19, 92);
            lMetodoPago.Name = "lMetodoPago";
            lMetodoPago.Size = new Size(123, 20);
            lMetodoPago.TabIndex = 14;
            lMetodoPago.Text = "Método de Pago";
            // 
            // tbMonto
            // 
            tbMonto.BackColor = SystemColors.Control;
            tbMonto.Location = new Point(19, 45);
            tbMonto.Name = "tbMonto";
            tbMonto.Size = new Size(263, 29);
            tbMonto.TabIndex = 12;
            // 
            // lMontoTotal
            // 
            lMontoTotal.AutoSize = true;
            lMontoTotal.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lMontoTotal.ForeColor = Color.DarkSlateGray;
            lMontoTotal.Location = new Point(19, 22);
            lMontoTotal.Name = "lMontoTotal";
            lMontoTotal.Size = new Size(90, 20);
            lMontoTotal.TabIndex = 5;
            lMontoTotal.Text = "Monto total";
            // 
            // tbCantPers
            // 
            tbCantPers.BackColor = SystemColors.Control;
            tbCantPers.Location = new Point(24, 159);
            tbCantPers.Name = "tbCantPers";
            tbCantPers.Size = new Size(254, 29);
            tbCantPers.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(24, 136);
            label3.Name = "label3";
            label3.Size = new Size(156, 20);
            label3.TabIndex = 15;
            label3.Text = "Cantidad de personas";
            // 
            // bCancelar
            // 
            bCancelar.BackColor = SystemColors.InactiveCaption;
            bCancelar.FlatAppearance.BorderSize = 0;
            bCancelar.FlatStyle = FlatStyle.Flat;
            bCancelar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bCancelar.ForeColor = Color.DarkSlateGray;
            bCancelar.Location = new Point(623, 409);
            bCancelar.Name = "bCancelar";
            bCancelar.Size = new Size(99, 31);
            bCancelar.TabIndex = 11;
            bCancelar.Text = "Cancelar";
            bCancelar.UseVisualStyleBackColor = false;
            // 
            // tbCliente
            // 
            tbCliente.BackColor = SystemColors.Control;
            tbCliente.Location = new Point(24, 93);
            tbCliente.Name = "tbCliente";
            tbCliente.Size = new Size(254, 29);
            tbCliente.TabIndex = 9;
            // 
            // cbHabitacion
            // 
            cbHabitacion.BackColor = SystemColors.Control;
            cbHabitacion.FormattingEnabled = true;
            cbHabitacion.Location = new Point(424, 93);
            cbHabitacion.Name = "cbHabitacion";
            cbHabitacion.Size = new Size(254, 29);
            cbHabitacion.TabIndex = 8;
            // 
            // dtFechaSalida
            // 
            dtFechaSalida.CalendarMonthBackground = SystemColors.Control;
            dtFechaSalida.CalendarTitleBackColor = SystemColors.ButtonShadow;
            dtFechaSalida.Format = DateTimePickerFormat.Short;
            dtFechaSalida.Location = new Point(24, 290);
            dtFechaSalida.Name = "dtFechaSalida";
            dtFechaSalida.Size = new Size(254, 29);
            dtFechaSalida.TabIndex = 7;
            // 
            // dtFechaIngreso
            // 
            dtFechaIngreso.CalendarMonthBackground = SystemColors.Control;
            dtFechaIngreso.Format = DateTimePickerFormat.Short;
            dtFechaIngreso.Location = new Point(24, 221);
            dtFechaIngreso.Name = "dtFechaIngreso";
            dtFechaIngreso.Size = new Size(254, 29);
            dtFechaIngreso.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(424, 72);
            label5.Name = "label5";
            label5.Size = new Size(89, 21);
            label5.TabIndex = 4;
            label5.Text = "Habitación";
            // 
            // lFechaSalida
            // 
            lFechaSalida.AutoSize = true;
            lFechaSalida.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lFechaSalida.ForeColor = Color.DarkSlateGray;
            lFechaSalida.Location = new Point(24, 267);
            lFechaSalida.Name = "lFechaSalida";
            lFechaSalida.Size = new Size(115, 20);
            lFechaSalida.TabIndex = 3;
            lFechaSalida.Text = "Fecha de Salida";
            // 
            // lFechaIngreso
            // 
            lFechaIngreso.AutoSize = true;
            lFechaIngreso.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lFechaIngreso.ForeColor = Color.DarkSlateGray;
            lFechaIngreso.Location = new Point(24, 198);
            lFechaIngreso.Name = "lFechaIngreso";
            lFechaIngreso.Size = new Size(125, 20);
            lFechaIngreso.TabIndex = 2;
            lFechaIngreso.Text = "Fecha de Ingreso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(24, 73);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "Cliente";
            // 
            // lNuevaReserva
            // 
            lNuevaReserva.AutoSize = true;
            lNuevaReserva.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lNuevaReserva.ForeColor = Color.DarkSlateGray;
            lNuevaReserva.Location = new Point(24, 29);
            lNuevaReserva.Name = "lNuevaReserva";
            lNuevaReserva.Size = new Size(140, 25);
            lNuevaReserva.TabIndex = 0;
            lNuevaReserva.Text = "Nueva Reserva";
            // 
            // tpPendientes
            // 
            tpPendientes.BackColor = SystemColors.Control;
            tpPendientes.Controls.Add(dgvPendientes);
            tpPendientes.Controls.Add(label1);
            tpPendientes.Location = new Point(4, 30);
            tpPendientes.Name = "tpPendientes";
            tpPendientes.Padding = new Padding(3);
            tpPendientes.Size = new Size(777, 462);
            tpPendientes.TabIndex = 4;
            tpPendientes.Text = "Pendientes";
            // 
            // dgvPendientes
            // 
            dgvPendientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPendientes.BackgroundColor = SystemColors.InactiveCaption;
            dgvPendientes.BorderStyle = BorderStyle.None;
            dgvPendientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPendientes.Location = new Point(3, 77);
            dgvPendientes.Name = "dgvPendientes";
            dgvPendientes.Size = new Size(771, 325);
            dgvPendientes.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(24, 21);
            label1.Name = "label1";
            label1.Size = new Size(154, 25);
            label1.TabIndex = 5;
            label1.Text = "Reservas Activas";
            // 
            // ReservasView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(790, 542);
            Controls.Add(lReservas);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ReservasView";
            Text = "ReservasView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tpTodos.ResumeLayout(false);
            tpTodos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTodos).EndInit();
            tpActivos.ResumeLayout(false);
            tpActivos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActivos).EndInit();
            tpFinalizados.ResumeLayout(false);
            tpFinalizados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFinalizadas).EndInit();
            tpNuevaReserva.ResumeLayout(false);
            tpNuevaReserva.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tpPendientes.ResumeLayout(false);
            tpPendientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPendientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lReservas;
        private TabControl tabControl1;
        private TabPage tpTodos;
        private TabPage tpActivos;
        private TabPage tpFinalizados;
        private TabPage tpNuevaReserva;
        private Label lMontoTotal;
        private Label label5;
        private Label lFechaSalida;
        private Label lFechaIngreso;
        private Label label2;
        private Label lNuevaReserva;
        private DateTimePicker dtFechaSalida;
        private DateTimePicker dtFechaIngreso;
        private ComboBox cbHabitacion;
        private Button bCancelar;
        private TextBox tbCliente;
        private Label lMetodoPago;
        private ComboBox cbFPago;
        private TextBox tbMonto;
        private TextBox tbCantPers;
        private Label label3;
        private Button bConfirmar;
        private Panel panel2;
        private DataGridView dgvFinalizadas;
        private Label lReservasFin;
        private DataGridView dgvTodos;
        private Label lReservasTodas;
        private Label lReservasAct;
        private DataGridView dgvActivos;
        private Label lMotorEmpleados;
        private TextBox txtSearch;
        private Button bBuscar;
        private Button bNuevo;
        private Button bEditar;
        private Button bEliminar;
        private ComboBox cbTipoHab;
        private Label lTipoHabt;
        private TabPage tpPendientes;
        private DataGridView dgvPendientes;
        private Label label1;
    }
}