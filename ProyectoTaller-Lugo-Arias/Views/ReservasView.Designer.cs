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
            textBox4 = new TextBox();
            lMotorEmpleados = new Label();
            lReservas = new Label();
            tabControl1 = new TabControl();
            tpTodos = new TabPage();
            dataGridView3 = new DataGridView();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn3 = new DataGridViewButtonColumn();
            dataGridViewButtonColumn4 = new DataGridViewButtonColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            lReservasTodas = new Label();
            tpActivos = new TabPage();
            lReservasAct = new Label();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
            dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            tpFinalizados = new TabPage();
            dataGridView1 = new DataGridView();
            ColumnaNroReserva = new DataGridViewTextBoxColumn();
            ColumnaClienteDNI = new DataGridViewTextBoxColumn();
            ColumnaHabitacion = new DataGridViewTextBoxColumn();
            ColumnaIngreso = new DataGridViewTextBoxColumn();
            ColumnaSalida = new DataGridViewTextBoxColumn();
            ColumnaEditar = new DataGridViewButtonColumn();
            ColumnaEliminar = new DataGridViewButtonColumn();
            ColumnaEstado = new DataGridViewTextBoxColumn();
            lReservasFin = new Label();
            tpNuevaReserva = new TabPage();
            bConfirmar = new Button();
            panel2 = new Panel();
            comboBox2 = new ComboBox();
            lMetodoPago = new Label();
            textBox2 = new TextBox();
            lMontoTotal = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            bCancelar = new Button();
            bCalcularPrecio = new Button();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            lFechaSalida = new Label();
            lFechaIngreso = new Label();
            label2 = new Label();
            lNuevaReserva = new Label();
            bBuscar = new Button();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tpTodos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tpActivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tpFinalizados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tpNuevaReserva.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(bBuscar);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(lMotorEmpleados);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(790, 69);
            panel1.TabIndex = 0;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Control;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(28, 29);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(534, 16);
            textBox4.TabIndex = 2;
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
            lReservas.Location = new Point(332, 83);
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
            tabControl1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
<<<<<<< HEAD
            tabControl1.Location = new Point(0, 136);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(785, 406);
=======
            tabControl1.Location = new Point(0, 137);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(785, 482);
>>>>>>> ada75638ee117256bc6eb2de1874ad2b4187e547
            tabControl1.TabIndex = 1;
            // 
            // tpTodos
            // 
            tpTodos.BackColor = SystemColors.Control;
            tpTodos.Controls.Add(dataGridView3);
            tpTodos.Controls.Add(lReservasTodas);
            tpTodos.Location = new Point(4, 30);
            tpTodos.Name = "tpTodos";
            tpTodos.Padding = new Padding(3);
<<<<<<< HEAD
            tpTodos.Size = new Size(777, 372);
=======
            tpTodos.Size = new Size(777, 448);
>>>>>>> ada75638ee117256bc6eb2de1874ad2b4187e547
            tpTodos.TabIndex = 0;
            tpTodos.Text = "Todos";
            // 
            // dataGridView3
            // 
            dataGridView3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView3.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewButtonColumn3, dataGridViewButtonColumn4, dataGridViewTextBoxColumn12 });
<<<<<<< HEAD
            dataGridView3.Location = new Point(-4, 67);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(785, 366);
=======
            dataGridView3.Dock = DockStyle.Bottom;
            dataGridView3.Location = new Point(3, 70);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(771, 375);
>>>>>>> ada75638ee117256bc6eb2de1874ad2b4187e547
            dataGridView3.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Nro. Reserva";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "DNI Cliente";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Habitación";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Ingreso";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.HeaderText = "Salida";
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewButtonColumn3
            // 
            dataGridViewButtonColumn3.HeaderText = "Editar";
            dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
            dataGridViewButtonColumn3.Resizable = DataGridViewTriState.True;
            dataGridViewButtonColumn3.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewButtonColumn4
            // 
            dataGridViewButtonColumn4.HeaderText = "Eliminar";
            dataGridViewButtonColumn4.Name = "dataGridViewButtonColumn4";
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.HeaderText = "Estado";
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
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
            tpActivos.Controls.Add(dataGridView2);
            tpActivos.ForeColor = Color.DarkSlateGray;
            tpActivos.Location = new Point(4, 30);
            tpActivos.Name = "tpActivos";
            tpActivos.Padding = new Padding(3);
<<<<<<< HEAD
            tpActivos.Size = new Size(777, 372);
=======
            tpActivos.Size = new Size(777, 474);
>>>>>>> ada75638ee117256bc6eb2de1874ad2b4187e547
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
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewButtonColumn1, dataGridViewButtonColumn2, dataGridViewTextBoxColumn6 });
            dataGridView2.Location = new Point(3, 71);
            dataGridView2.Name = "dataGridView2";
<<<<<<< HEAD
            dataGridView2.Size = new Size(769, 290);
=======
            dataGridView2.Size = new Size(771, 370);
>>>>>>> ada75638ee117256bc6eb2de1874ad2b4187e547
            dataGridView2.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Nro. Reserva";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "DNI Cliente";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Habitación";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Ingreso";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Salida";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewButtonColumn1.HeaderText = "Editar";
            dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            dataGridViewButtonColumn1.Resizable = DataGridViewTriState.True;
            dataGridViewButtonColumn1.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewButtonColumn2
            // 
            dataGridViewButtonColumn2.HeaderText = "Eliminar";
            dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Estado";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // tpFinalizados
            // 
            tpFinalizados.BackColor = SystemColors.Control;
            tpFinalizados.Controls.Add(dataGridView1);
            tpFinalizados.Controls.Add(lReservasFin);
            tpFinalizados.Location = new Point(4, 30);
            tpFinalizados.Name = "tpFinalizados";
            tpFinalizados.Padding = new Padding(3);
            tpFinalizados.Size = new Size(777, 372);
            tpFinalizados.TabIndex = 2;
            tpFinalizados.Text = "Finalizados";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnaNroReserva, ColumnaClienteDNI, ColumnaHabitacion, ColumnaIngreso, ColumnaSalida, ColumnaEditar, ColumnaEliminar, ColumnaEstado });
            dataGridView1.Location = new Point(3, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(771, 295);
            dataGridView1.TabIndex = 2;
            // 
            // ColumnaNroReserva
            // 
            ColumnaNroReserva.HeaderText = "Nro. Reserva";
            ColumnaNroReserva.Name = "ColumnaNroReserva";
            // 
            // ColumnaClienteDNI
            // 
            ColumnaClienteDNI.HeaderText = "DNI Cliente";
            ColumnaClienteDNI.Name = "ColumnaClienteDNI";
            // 
            // ColumnaHabitacion
            // 
            ColumnaHabitacion.HeaderText = "Habitación";
            ColumnaHabitacion.Name = "ColumnaHabitacion";
            // 
            // ColumnaIngreso
            // 
            ColumnaIngreso.HeaderText = "Ingreso";
            ColumnaIngreso.Name = "ColumnaIngreso";
            // 
            // ColumnaSalida
            // 
            ColumnaSalida.HeaderText = "Salida";
            ColumnaSalida.Name = "ColumnaSalida";
            // 
            // ColumnaEditar
            // 
            ColumnaEditar.HeaderText = "Editar";
            ColumnaEditar.Name = "ColumnaEditar";
            ColumnaEditar.Resizable = DataGridViewTriState.True;
            ColumnaEditar.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnaEliminar
            // 
            ColumnaEliminar.HeaderText = "Eliminar";
            ColumnaEliminar.Name = "ColumnaEliminar";
            // 
            // ColumnaEstado
            // 
            ColumnaEstado.HeaderText = "Estado";
            ColumnaEstado.Name = "ColumnaEstado";
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
            tpNuevaReserva.Controls.Add(bConfirmar);
            tpNuevaReserva.Controls.Add(panel2);
            tpNuevaReserva.Controls.Add(textBox3);
            tpNuevaReserva.Controls.Add(label3);
            tpNuevaReserva.Controls.Add(bCancelar);
            tpNuevaReserva.Controls.Add(bCalcularPrecio);
            tpNuevaReserva.Controls.Add(textBox1);
            tpNuevaReserva.Controls.Add(comboBox1);
            tpNuevaReserva.Controls.Add(dateTimePicker2);
            tpNuevaReserva.Controls.Add(dateTimePicker1);
            tpNuevaReserva.Controls.Add(label5);
            tpNuevaReserva.Controls.Add(lFechaSalida);
            tpNuevaReserva.Controls.Add(lFechaIngreso);
            tpNuevaReserva.Controls.Add(label2);
            tpNuevaReserva.Controls.Add(lNuevaReserva);
            tpNuevaReserva.Location = new Point(4, 30);
            tpNuevaReserva.Name = "tpNuevaReserva";
            tpNuevaReserva.Padding = new Padding(3);
            tpNuevaReserva.Size = new Size(777, 372);
            tpNuevaReserva.TabIndex = 3;
            tpNuevaReserva.Text = "Nueva Reserva";
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
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(lMetodoPago);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(lMontoTotal);
            panel2.Location = new Point(424, 136);
            panel2.Name = "panel2";
            panel2.Size = new Size(298, 187);
            panel2.TabIndex = 17;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = SystemColors.Control;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(19, 122);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(263, 29);
            comboBox2.TabIndex = 13;
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
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.Location = new Point(19, 45);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(263, 29);
            textBox2.TabIndex = 12;
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
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Control;
            textBox3.Location = new Point(24, 159);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(254, 29);
            textBox3.TabIndex = 16;
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
            // bCalcularPrecio
            // 
            bCalcularPrecio.BackColor = Color.DarkSlateGray;
            bCalcularPrecio.FlatAppearance.BorderSize = 0;
            bCalcularPrecio.FlatStyle = FlatStyle.Flat;
            bCalcularPrecio.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bCalcularPrecio.ForeColor = SystemColors.InactiveBorder;
            bCalcularPrecio.Location = new Point(77, 409);
            bCalcularPrecio.Name = "bCalcularPrecio";
            bCalcularPrecio.Size = new Size(137, 31);
            bCalcularPrecio.TabIndex = 10;
            bCalcularPrecio.Text = "Calcular precio";
            bCalcularPrecio.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.Location = new Point(24, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(254, 29);
            textBox1.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.Control;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(24, 353);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(254, 29);
            comboBox1.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CalendarMonthBackground = SystemColors.Control;
            dateTimePicker2.CalendarTitleBackColor = SystemColors.ButtonShadow;
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(24, 290);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(254, 29);
            dateTimePicker2.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = SystemColors.Control;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(24, 221);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(254, 29);
            dateTimePicker1.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 333);
            label5.Name = "label5";
            label5.Size = new Size(70, 17);
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
            // bBuscar
            // 
            bBuscar.Location = new Point(568, 25);
            bBuscar.Name = "bBuscar";
            bBuscar.Size = new Size(75, 23);
            bBuscar.TabIndex = 3;
            bBuscar.Text = "Buscar";
            bBuscar.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tpActivos.ResumeLayout(false);
            tpActivos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tpFinalizados.ResumeLayout(false);
            tpFinalizados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tpNuevaReserva.ResumeLayout(false);
            tpNuevaReserva.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Button bCancelar;
        private Button bCalcularPrecio;
        private TextBox textBox1;
        private Label lMetodoPago;
        private ComboBox comboBox2;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private Button bConfirmar;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label lReservasFin;
        private DataGridViewTextBoxColumn ColumnaNroReserva;
        private DataGridViewTextBoxColumn ColumnaClienteDNI;
        private DataGridViewTextBoxColumn ColumnaHabitacion;
        private DataGridViewTextBoxColumn ColumnaIngreso;
        private DataGridViewTextBoxColumn ColumnaSalida;
        private DataGridViewButtonColumn ColumnaEditar;
        private DataGridViewButtonColumn ColumnaEliminar;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewButtonColumn dataGridViewButtonColumn3;
        private DataGridViewButtonColumn dataGridViewButtonColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private Label lReservasTodas;
        private Label lReservasAct;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private DataGridViewButtonColumn dataGridViewButtonColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn ColumnaEstado;
        private Label lMotorEmpleados;
        private TextBox textBox4;
        private Button bBuscar;
    }
}