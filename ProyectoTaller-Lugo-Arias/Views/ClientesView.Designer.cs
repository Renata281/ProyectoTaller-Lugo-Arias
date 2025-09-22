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
            textBox4 = new TextBox();
            lMotorEmpleados = new Label();
            label1 = new Label();
            tabControl1 = new TabControl();
            tpTodos = new TabPage();
            dataGridView3 = new DataGridView();
            lReservasTodas = new Label();
            tpActivos = new TabPage();
            lReservasAct = new Label();
            tpFinalizados = new TabPage();
            lReservasFin = new Label();
            tpNuevaReserva = new TabPage();
            label6 = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
            bConfirmar = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            bCancelar = new Button();
            textBox1 = new TextBox();
            lFechaIngreso = new Label();
            label2 = new Label();
            lNuevaReserva = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn17 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tpTodos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tpActivos.SuspendLayout();
            tpFinalizados.SuspendLayout();
            tpNuevaReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(lMotorEmpleados);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(869, 69);
            panel1.TabIndex = 2;
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
            tabControl1.Controls.Add(tpFinalizados);
            tabControl1.Controls.Add(tpNuevaReserva);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 180);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(869, 368);
            tabControl1.TabIndex = 4;
            // 
            // tpTodos
            // 
            tpTodos.BackColor = SystemColors.Control;
            tpTodos.Controls.Add(dataGridView3);
            tpTodos.Controls.Add(lReservasTodas);
            tpTodos.Location = new Point(4, 30);
            tpTodos.Name = "tpTodos";
            tpTodos.Padding = new Padding(3);
            tpTodos.Size = new Size(861, 334);
            tpTodos.TabIndex = 0;
            tpTodos.Text = "Todos";
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, Column1, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11 });
            dataGridView3.Dock = DockStyle.Bottom;
            dataGridView3.Location = new Point(3, 79);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(855, 252);
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
            tpActivos.Size = new Size(861, 334);
            tpActivos.TabIndex = 1;
            tpActivos.Text = "Activos";
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
            // tpFinalizados
            // 
            tpFinalizados.BackColor = SystemColors.Control;
            tpFinalizados.Controls.Add(dataGridView1);
            tpFinalizados.Controls.Add(lReservasFin);
            tpFinalizados.Location = new Point(4, 30);
            tpFinalizados.Name = "tpFinalizados";
            tpFinalizados.Padding = new Padding(3);
            tpFinalizados.Size = new Size(861, 334);
            tpFinalizados.TabIndex = 2;
            tpFinalizados.Text = "Inactivos";
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
            // tpNuevaReserva
            // 
            tpNuevaReserva.BackColor = SystemColors.Control;
            tpNuevaReserva.Controls.Add(textBox7);
            tpNuevaReserva.Controls.Add(textBox6);
            tpNuevaReserva.Controls.Add(label6);
            tpNuevaReserva.Controls.Add(label5);
            tpNuevaReserva.Controls.Add(textBox5);
            tpNuevaReserva.Controls.Add(bConfirmar);
            tpNuevaReserva.Controls.Add(textBox3);
            tpNuevaReserva.Controls.Add(label3);
            tpNuevaReserva.Controls.Add(bCancelar);
            tpNuevaReserva.Controls.Add(textBox1);
            tpNuevaReserva.Controls.Add(lFechaIngreso);
            tpNuevaReserva.Controls.Add(label2);
            tpNuevaReserva.Controls.Add(lNuevaReserva);
            tpNuevaReserva.Location = new Point(4, 30);
            tpNuevaReserva.Name = "tpNuevaReserva";
            tpNuevaReserva.Padding = new Padding(3);
            tpNuevaReserva.Size = new Size(861, 334);
            tpNuevaReserva.TabIndex = 3;
            tpNuevaReserva.Text = "Nuevo Cliente";
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
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Control;
            textBox5.Location = new Point(27, 238);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(254, 29);
            textBox5.TabIndex = 19;
            // 
            // bConfirmar
            // 
            bConfirmar.BackColor = Color.DarkSlateGray;
            bConfirmar.FlatAppearance.BorderSize = 0;
            bConfirmar.FlatStyle = FlatStyle.Flat;
            bConfirmar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bConfirmar.ForeColor = SystemColors.InactiveBorder;
            bConfirmar.Location = new Point(281, 297);
            bConfirmar.Name = "bConfirmar";
            bConfirmar.Size = new Size(99, 31);
            bConfirmar.TabIndex = 18;
            bConfirmar.Text = "Confirmar";
            bConfirmar.UseVisualStyleBackColor = false;
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
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.Location = new Point(24, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(254, 29);
            textBox1.TabIndex = 9;
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
            // textBox6
            // 
            textBox6.BackColor = SystemColors.Control;
            textBox6.Location = new Point(334, 96);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(254, 29);
            textBox6.TabIndex = 24;
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.Control;
            textBox7.Location = new Point(334, 165);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(254, 29);
            textBox7.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Id Cliente";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre";
            Column1.Name = "Column1";
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Apellido";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Email";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Teléfono";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.HeaderText = "DNI";
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn16 });
            dataGridView2.Dock = DockStyle.Bottom;
            dataGridView2.Location = new Point(3, 79);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(855, 252);
            dataGridView2.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Id Cliente";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Apellido";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Email";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Teléfono";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn16
            // 
            dataGridViewTextBoxColumn16.HeaderText = "DNI";
            dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn12, dataGridViewTextBoxColumn13, dataGridViewTextBoxColumn14, dataGridViewTextBoxColumn15, dataGridViewTextBoxColumn17 });
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(3, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(855, 252);
            dataGridView1.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Id Cliente";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.HeaderText = "Nombre";
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.HeaderText = "Apellido";
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewTextBoxColumn14.HeaderText = "Email";
            dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            dataGridViewTextBoxColumn15.HeaderText = "Teléfono";
            dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn17
            // 
            dataGridViewTextBoxColumn17.HeaderText = "DNI";
            dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
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
            tpFinalizados.ResumeLayout(false);
            tpFinalizados.PerformLayout();
            tpNuevaReserva.ResumeLayout(false);
            tpNuevaReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox4;
        private Label lMotorEmpleados;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tpTodos;
        private DataGridView dataGridView3;
        private Label lReservasTodas;
        private TabPage tpActivos;
        private Label lReservasAct;
        private TabPage tpFinalizados;
        private Label lReservasFin;
        private TabPage tpNuevaReserva;
        private Label label6;
        private Label label5;
        private TextBox textBox5;
        private Button bConfirmar;
        private TextBox textBox3;
        private Label label3;
        private Button bCancelar;
        private TextBox textBox1;
        private Label lFechaIngreso;
        private Label label2;
        private Label lNuevaReserva;
        private TextBox textBox7;
        private TextBox textBox6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
    }
}