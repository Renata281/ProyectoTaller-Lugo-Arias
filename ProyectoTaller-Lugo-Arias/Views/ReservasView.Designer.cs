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
            label1 = new Label();
            tabControl1 = new TabControl();
            tpTodos = new TabPage();
            tpActivos = new TabPage();
            tpFinalizados = new TabPage();
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
            lReservasFin = new Label();
            dataGridView1 = new DataGridView();
            ColumnaNroReserva = new DataGridViewTextBoxColumn();
            ColumnaClienteDNI = new DataGridViewTextBoxColumn();
            ColumnaHabitacion = new DataGridViewTextBoxColumn();
            ColumnaIngreso = new DataGridViewTextBoxColumn();
            ColumnaSalida = new DataGridViewTextBoxColumn();
            ColumnaEditar = new DataGridViewButtonColumn();
            ColumnaEliminar = new DataGridViewButtonColumn();
            ColumnaEstado = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
            dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            lReservasAct = new Label();
            lReservasTodas = new Label();
            dataGridView3 = new DataGridView();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn3 = new DataGridViewButtonColumn();
            dataGridViewButtonColumn4 = new DataGridViewButtonColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tpTodos.SuspendLayout();
            tpActivos.SuspendLayout();
            tpFinalizados.SuspendLayout();
            tpNuevaReserva.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(783, 68);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(356, 22);
            label1.Name = "label1";
            label1.Size = new Size(97, 30);
            label1.TabIndex = 0;
            label1.Text = "Reservas";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpTodos);
            tabControl1.Controls.Add(tpActivos);
            tabControl1.Controls.Add(tpFinalizados);
            tabControl1.Controls.Add(tpNuevaReserva);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 68);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(783, 525);
            tabControl1.TabIndex = 1;
            // 
            // tpTodos
            // 
            tpTodos.Controls.Add(dataGridView3);
            tpTodos.Controls.Add(lReservasTodas);
            tpTodos.Location = new Point(4, 24);
            tpTodos.Name = "tpTodos";
            tpTodos.Padding = new Padding(3);
            tpTodos.Size = new Size(775, 497);
            tpTodos.TabIndex = 0;
            tpTodos.Text = "Todos";
            tpTodos.UseVisualStyleBackColor = true;
            // 
            // tpActivos
            // 
            tpActivos.Controls.Add(lReservasAct);
            tpActivos.Controls.Add(dataGridView2);
            tpActivos.Location = new Point(4, 24);
            tpActivos.Name = "tpActivos";
            tpActivos.Padding = new Padding(3);
            tpActivos.Size = new Size(775, 498);
            tpActivos.TabIndex = 1;
            tpActivos.Text = "Activos";
            tpActivos.UseVisualStyleBackColor = true;
            // 
            // tpFinalizados
            // 
            tpFinalizados.Controls.Add(dataGridView1);
            tpFinalizados.Controls.Add(lReservasFin);
            tpFinalizados.Location = new Point(4, 24);
            tpFinalizados.Name = "tpFinalizados";
            tpFinalizados.Padding = new Padding(3);
            tpFinalizados.Size = new Size(775, 498);
            tpFinalizados.TabIndex = 2;
            tpFinalizados.Text = "Finalizados";
            tpFinalizados.UseVisualStyleBackColor = true;
            // 
            // tpNuevaReserva
            // 
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
            tpNuevaReserva.Location = new Point(4, 24);
            tpNuevaReserva.Name = "tpNuevaReserva";
            tpNuevaReserva.Padding = new Padding(3);
            tpNuevaReserva.Size = new Size(775, 498);
            tpNuevaReserva.TabIndex = 3;
            tpNuevaReserva.Text = "Nueva Reserva";
            tpNuevaReserva.UseVisualStyleBackColor = true;
            // 
            // bConfirmar
            // 
            bConfirmar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bConfirmar.Location = new Point(572, 426);
            bConfirmar.Name = "bConfirmar";
            bConfirmar.Size = new Size(84, 31);
            bConfirmar.TabIndex = 18;
            bConfirmar.Text = "Confirmar";
            bConfirmar.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(lMetodoPago);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(lMontoTotal);
            panel2.Location = new Point(423, 154);
            panel2.Name = "panel2";
            panel2.Size = new Size(298, 187);
            panel2.TabIndex = 17;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(19, 122);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(263, 23);
            comboBox2.TabIndex = 13;
            // 
            // lMetodoPago
            // 
            lMetodoPago.AutoSize = true;
            lMetodoPago.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lMetodoPago.Location = new Point(19, 92);
            lMetodoPago.Name = "lMetodoPago";
            lMetodoPago.Size = new Size(108, 17);
            lMetodoPago.TabIndex = 14;
            lMetodoPago.Text = "Método de Pago";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(19, 53);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(263, 23);
            textBox2.TabIndex = 12;
            // 
            // lMontoTotal
            // 
            lMontoTotal.AutoSize = true;
            lMontoTotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lMontoTotal.Location = new Point(19, 22);
            lMontoTotal.Name = "lMontoTotal";
            lMontoTotal.Size = new Size(77, 17);
            lMontoTotal.TabIndex = 5;
            lMontoTotal.Text = "Monto total";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(24, 174);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(254, 23);
            textBox3.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 154);
            label3.Name = "label3";
            label3.Size = new Size(137, 17);
            label3.TabIndex = 15;
            label3.Text = "Cantidad de personas";
            // 
            // bCancelar
            // 
            bCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bCancelar.Location = new Point(675, 426);
            bCancelar.Name = "bCancelar";
            bCancelar.Size = new Size(84, 31);
            bCancelar.TabIndex = 11;
            bCancelar.Text = "Cancelar";
            bCancelar.UseVisualStyleBackColor = true;
            // 
            // bCalcularPrecio
            // 
            bCalcularPrecio.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bCalcularPrecio.Location = new Point(24, 426);
            bCalcularPrecio.Name = "bCalcularPrecio";
            bCalcularPrecio.Size = new Size(108, 31);
            bCalcularPrecio.TabIndex = 10;
            bCalcularPrecio.Text = "Calcular precio";
            bCalcularPrecio.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(24, 119);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(254, 23);
            textBox1.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(24, 383);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(254, 23);
            comboBox1.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(24, 313);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(254, 23);
            dateTimePicker2.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(24, 244);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(254, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 352);
            label5.Name = "label5";
            label5.Size = new Size(70, 17);
            label5.TabIndex = 4;
            label5.Text = "Habitación";
            // 
            // lFechaSalida
            // 
            lFechaSalida.AutoSize = true;
            lFechaSalida.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lFechaSalida.Location = new Point(24, 283);
            lFechaSalida.Name = "lFechaSalida";
            lFechaSalida.Size = new Size(99, 17);
            lFechaSalida.TabIndex = 3;
            lFechaSalida.Text = "Fecha de Salida";
            // 
            // lFechaIngreso
            // 
            lFechaIngreso.AutoSize = true;
            lFechaIngreso.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lFechaIngreso.Location = new Point(24, 213);
            lFechaIngreso.Name = "lFechaIngreso";
            lFechaIngreso.Size = new Size(108, 17);
            lFechaIngreso.TabIndex = 2;
            lFechaIngreso.Text = "Fecha de Ingreso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 90);
            label2.Name = "label2";
            label2.Size = new Size(47, 17);
            label2.TabIndex = 1;
            label2.Text = "Cliente";
            // 
            // lNuevaReserva
            // 
            lNuevaReserva.AutoSize = true;
            lNuevaReserva.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lNuevaReserva.Location = new Point(24, 29);
            lNuevaReserva.Name = "lNuevaReserva";
            lNuevaReserva.Size = new Size(135, 25);
            lNuevaReserva.TabIndex = 0;
            lNuevaReserva.Text = "Nueva Reserva";
            // 
            // lReservasFin
            // 
            lReservasFin.AutoSize = true;
            lReservasFin.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lReservasFin.Location = new Point(23, 26);
            lReservasFin.Name = "lReservasFin";
            lReservasFin.Size = new Size(182, 25);
            lReservasFin.TabIndex = 1;
            lReservasFin.Text = "Reservas Finalizadas";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnaNroReserva, ColumnaClienteDNI, ColumnaHabitacion, ColumnaIngreso, ColumnaSalida, ColumnaEditar, ColumnaEliminar, ColumnaEstado });
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(3, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(769, 418);
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
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewButtonColumn1, dataGridViewButtonColumn2, dataGridViewTextBoxColumn6 });
            dataGridView2.Dock = DockStyle.Bottom;
            dataGridView2.Location = new Point(3, 77);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(769, 418);
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
            // lReservasAct
            // 
            lReservasAct.AutoSize = true;
            lReservasAct.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lReservasAct.Location = new Point(20, 27);
            lReservasAct.Name = "lReservasAct";
            lReservasAct.Size = new Size(148, 25);
            lReservasAct.TabIndex = 4;
            lReservasAct.Text = "Reservas Activas";
            // 
            // lReservasTodas
            // 
            lReservasTodas.AutoSize = true;
            lReservasTodas.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lReservasTodas.Location = new Point(21, 22);
            lReservasTodas.Name = "lReservasTodas";
            lReservasTodas.Size = new Size(84, 25);
            lReservasTodas.TabIndex = 2;
            lReservasTodas.Text = "Reservas";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewButtonColumn3, dataGridViewButtonColumn4, dataGridViewTextBoxColumn12 });
            dataGridView3.Dock = DockStyle.Bottom;
            dataGridView3.Location = new Point(3, 76);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(769, 418);
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
            // ReservasView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 593);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ReservasView";
            Text = "ReservasView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tpTodos.ResumeLayout(false);
            tpTodos.PerformLayout();
            tpActivos.ResumeLayout(false);
            tpActivos.PerformLayout();
            tpFinalizados.ResumeLayout(false);
            tpFinalizados.PerformLayout();
            tpNuevaReserva.ResumeLayout(false);
            tpNuevaReserva.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
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
    }
}