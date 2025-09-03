namespace ProyectoTaller_Lugo_Arias.Views
{
    partial class TipoHabitacionView
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
            lBuscarTipoHabit = new Label();
            tbBuscarTipoHabit = new TextBox();
            lTipoHabit = new Label();
            tNuevaHabitación = new TabControl();
            tTodos = new TabPage();
            dataGridView1 = new DataGridView();
            ColumnaTipo = new DataGridViewTextBoxColumn();
            ColumnaCamas = new DataGridViewTextBoxColumn();
            ColumnaDescripcion = new DataGridViewTextBoxColumn();
            ColumnaEditar = new DataGridViewButtonColumn();
            ColumnaEliminar = new DataGridViewButtonColumn();
            lTodos = new Label();
            tabPage2 = new TabPage();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
            dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
            lIndividual = new Label();
            tDoble = new TabPage();
            dataGridView3 = new DataGridView();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn3 = new DataGridViewButtonColumn();
            dataGridViewButtonColumn4 = new DataGridViewButtonColumn();
            lDoble = new Label();
            tSuite = new TabPage();
            dataGridView4 = new DataGridView();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn5 = new DataGridViewButtonColumn();
            dataGridViewButtonColumn6 = new DataGridViewButtonColumn();
            lSuite = new Label();
            tNuevaHabit = new TabPage();
            bCancelar = new Button();
            bGuardar = new Button();
            tbDescripcion = new TextBox();
            tbCamas = new TextBox();
            tbNombre = new TextBox();
            lDescripcion = new Label();
            lCantCamas = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            tNuevaHabitación.SuspendLayout();
            tTodos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tDoble.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tSuite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            tNuevaHabit.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lBuscarTipoHabit);
            panel1.Controls.Add(tbBuscarTipoHabit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(759, 84);
            panel1.TabIndex = 0;
            // 
            // lBuscarTipoHabit
            // 
            lBuscarTipoHabit.AutoSize = true;
            lBuscarTipoHabit.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lBuscarTipoHabit.ForeColor = Color.DarkSlateGray;
            lBuscarTipoHabit.Location = new Point(34, 21);
            lBuscarTipoHabit.Name = "lBuscarTipoHabit";
            lBuscarTipoHabit.Size = new Size(117, 20);
            lBuscarTipoHabit.TabIndex = 1;
            lBuscarTipoHabit.Text = "Tipo Habitación";
            // 
            // tbBuscarTipoHabit
            // 
            tbBuscarTipoHabit.BackColor = SystemColors.Control;
            tbBuscarTipoHabit.Location = new Point(34, 44);
            tbBuscarTipoHabit.Name = "tbBuscarTipoHabit";
            tbBuscarTipoHabit.Size = new Size(579, 23);
            tbBuscarTipoHabit.TabIndex = 0;
            // 
            // lTipoHabit
            // 
            lTipoHabit.AutoSize = true;
            lTipoHabit.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lTipoHabit.ForeColor = Color.DarkSlateGray;
            lTipoHabit.Location = new Point(239, 103);
            lTipoHabit.Name = "lTipoHabit";
            lTipoHabit.Size = new Size(255, 32);
            lTipoHabit.TabIndex = 2;
            lTipoHabit.Text = "Tipo de Habitaciones";
            // 
            // tNuevaHabitación
            // 
            tNuevaHabitación.Controls.Add(tTodos);
            tNuevaHabitación.Controls.Add(tabPage2);
            tNuevaHabitación.Controls.Add(tDoble);
            tNuevaHabitación.Controls.Add(tSuite);
            tNuevaHabitación.Controls.Add(tNuevaHabit);
            tNuevaHabitación.Dock = DockStyle.Bottom;
            tNuevaHabitación.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tNuevaHabitación.Location = new Point(0, 155);
            tNuevaHabitación.Name = "tNuevaHabitación";
            tNuevaHabitación.SelectedIndex = 0;
            tNuevaHabitación.Size = new Size(759, 463);
            tNuevaHabitación.TabIndex = 3;
            // 
            // tTodos
            // 
            tTodos.BackColor = SystemColors.Control;
            tTodos.Controls.Add(dataGridView1);
            tTodos.Controls.Add(lTodos);
            tTodos.Location = new Point(4, 30);
            tTodos.Name = "tTodos";
            tTodos.Padding = new Padding(3);
            tTodos.Size = new Size(751, 429);
            tTodos.TabIndex = 0;
            tTodos.Text = "Todos";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnaTipo, ColumnaCamas, ColumnaDescripcion, ColumnaEditar, ColumnaEliminar });
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(3, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(745, 354);
            dataGridView1.TabIndex = 2;
            // 
            // ColumnaTipo
            // 
            ColumnaTipo.HeaderText = "Tipo";
            ColumnaTipo.Name = "ColumnaTipo";
            // 
            // ColumnaCamas
            // 
            ColumnaCamas.HeaderText = "Cantidad Camas";
            ColumnaCamas.Name = "ColumnaCamas";
            // 
            // ColumnaDescripcion
            // 
            ColumnaDescripcion.HeaderText = "Descripción";
            ColumnaDescripcion.Name = "ColumnaDescripcion";
            // 
            // ColumnaEditar
            // 
            ColumnaEditar.HeaderText = "Editar";
            ColumnaEditar.Name = "ColumnaEditar";
            // 
            // ColumnaEliminar
            // 
            ColumnaEliminar.HeaderText = "Eliminar";
            ColumnaEliminar.Name = "ColumnaEliminar";
            // 
            // lTodos
            // 
            lTodos.AutoSize = true;
            lTodos.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lTodos.ForeColor = Color.DarkSlateGray;
            lTodos.Location = new Point(21, 27);
            lTodos.Name = "lTodos";
            lTodos.Size = new Size(263, 25);
            lTodos.TabIndex = 1;
            lTodos.Text = "Lista de tipos de habitaciones";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(lIndividual);
            tabPage2.Location = new Point(4, 30);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(751, 429);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Individual";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewButtonColumn1, dataGridViewButtonColumn2 });
            dataGridView2.Dock = DockStyle.Bottom;
            dataGridView2.Location = new Point(3, 81);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(745, 345);
            dataGridView2.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Tipo";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Cantidad Camas";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Descripción";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewButtonColumn1.HeaderText = "Editar";
            dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            // 
            // dataGridViewButtonColumn2
            // 
            dataGridViewButtonColumn2.HeaderText = "Eliminar";
            dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            // 
            // lIndividual
            // 
            lIndividual.AutoSize = true;
            lIndividual.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lIndividual.ForeColor = Color.DarkSlateGray;
            lIndividual.Location = new Point(8, 30);
            lIndividual.Name = "lIndividual";
            lIndividual.Size = new Size(265, 25);
            lIndividual.TabIndex = 1;
            lIndividual.Text = "Tipo de habitación: Individual";
            // 
            // tDoble
            // 
            tDoble.BackColor = SystemColors.Control;
            tDoble.Controls.Add(dataGridView3);
            tDoble.Controls.Add(lDoble);
            tDoble.Location = new Point(4, 30);
            tDoble.Name = "tDoble";
            tDoble.Padding = new Padding(3);
            tDoble.Size = new Size(751, 429);
            tDoble.TabIndex = 2;
            tDoble.Text = "Doble";
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewButtonColumn3, dataGridViewButtonColumn4 });
            dataGridView3.Dock = DockStyle.Bottom;
            dataGridView3.Location = new Point(3, 76);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(745, 350);
            dataGridView3.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Tipo";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Cantidad Camas";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Descripción";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewButtonColumn3
            // 
            dataGridViewButtonColumn3.HeaderText = "Editar";
            dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
            // 
            // dataGridViewButtonColumn4
            // 
            dataGridViewButtonColumn4.HeaderText = "Eliminar";
            dataGridViewButtonColumn4.Name = "dataGridViewButtonColumn4";
            // 
            // lDoble
            // 
            lDoble.AutoSize = true;
            lDoble.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lDoble.ForeColor = Color.DarkSlateGray;
            lDoble.Location = new Point(17, 30);
            lDoble.Name = "lDoble";
            lDoble.Size = new Size(231, 25);
            lDoble.TabIndex = 1;
            lDoble.Text = "Tipo de habitación: Doble";
            // 
            // tSuite
            // 
            tSuite.Controls.Add(dataGridView4);
            tSuite.Controls.Add(lSuite);
            tSuite.Location = new Point(4, 30);
            tSuite.Name = "tSuite";
            tSuite.Padding = new Padding(3);
            tSuite.Size = new Size(751, 429);
            tSuite.TabIndex = 3;
            tSuite.Text = "Suite";
            tSuite.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            dataGridView4.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView4.BorderStyle = BorderStyle.None;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewButtonColumn5, dataGridViewButtonColumn6 });
            dataGridView4.Dock = DockStyle.Bottom;
            dataGridView4.Location = new Point(3, 75);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.Size = new Size(745, 351);
            dataGridView4.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Tipo";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Cantidad Camas";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Descripción";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewButtonColumn5
            // 
            dataGridViewButtonColumn5.HeaderText = "Editar";
            dataGridViewButtonColumn5.Name = "dataGridViewButtonColumn5";
            // 
            // dataGridViewButtonColumn6
            // 
            dataGridViewButtonColumn6.HeaderText = "Eliminar";
            dataGridViewButtonColumn6.Name = "dataGridViewButtonColumn6";
            // 
            // lSuite
            // 
            lSuite.AutoSize = true;
            lSuite.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lSuite.ForeColor = Color.DarkSlateGray;
            lSuite.Location = new Point(8, 27);
            lSuite.Name = "lSuite";
            lSuite.Size = new Size(223, 25);
            lSuite.TabIndex = 1;
            lSuite.Text = "Tipo de habitación: Suite";
            // 
            // tNuevaHabit
            // 
            tNuevaHabit.BackColor = SystemColors.Control;
            tNuevaHabit.Controls.Add(bCancelar);
            tNuevaHabit.Controls.Add(bGuardar);
            tNuevaHabit.Controls.Add(tbDescripcion);
            tNuevaHabit.Controls.Add(tbCamas);
            tNuevaHabit.Controls.Add(tbNombre);
            tNuevaHabit.Controls.Add(lDescripcion);
            tNuevaHabit.Controls.Add(lCantCamas);
            tNuevaHabit.Controls.Add(label2);
            tNuevaHabit.Controls.Add(label1);
            tNuevaHabit.Location = new Point(4, 30);
            tNuevaHabit.Name = "tNuevaHabit";
            tNuevaHabit.Padding = new Padding(3);
            tNuevaHabit.Size = new Size(751, 429);
            tNuevaHabit.TabIndex = 4;
            tNuevaHabit.Text = "Nueva habitación";
            // 
            // bCancelar
            // 
            bCancelar.BackColor = SystemColors.InactiveCaption;
            bCancelar.FlatAppearance.BorderSize = 0;
            bCancelar.FlatStyle = FlatStyle.Flat;
            bCancelar.ForeColor = Color.DarkSlateGray;
            bCancelar.Location = new Point(623, 374);
            bCancelar.Name = "bCancelar";
            bCancelar.Size = new Size(92, 36);
            bCancelar.TabIndex = 8;
            bCancelar.Text = "Cancelar";
            bCancelar.UseVisualStyleBackColor = false;
            // 
            // bGuardar
            // 
            bGuardar.BackColor = Color.DarkSlateGray;
            bGuardar.FlatAppearance.BorderSize = 0;
            bGuardar.FlatStyle = FlatStyle.Flat;
            bGuardar.ForeColor = SystemColors.InactiveBorder;
            bGuardar.Location = new Point(506, 374);
            bGuardar.Name = "bGuardar";
            bGuardar.Size = new Size(92, 36);
            bGuardar.TabIndex = 7;
            bGuardar.Text = "Guardar";
            bGuardar.UseVisualStyleBackColor = false;
            // 
            // tbDescripcion
            // 
            tbDescripcion.BackColor = SystemColors.ButtonHighlight;
            tbDescripcion.Location = new Point(30, 254);
            tbDescripcion.Multiline = true;
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.Size = new Size(252, 98);
            tbDescripcion.TabIndex = 6;
            // 
            // tbCamas
            // 
            tbCamas.BackColor = SystemColors.ButtonHighlight;
            tbCamas.Location = new Point(30, 176);
            tbCamas.Name = "tbCamas";
            tbCamas.Size = new Size(252, 29);
            tbCamas.TabIndex = 5;
            // 
            // tbNombre
            // 
            tbNombre.BackColor = SystemColors.ButtonHighlight;
            tbNombre.Location = new Point(30, 103);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(252, 29);
            tbNombre.TabIndex = 4;
            // 
            // lDescripcion
            // 
            lDescripcion.AutoSize = true;
            lDescripcion.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lDescripcion.ForeColor = Color.DarkSlateGray;
            lDescripcion.Location = new Point(30, 231);
            lDescripcion.Name = "lDescripcion";
            lDescripcion.Size = new Size(89, 20);
            lDescripcion.TabIndex = 3;
            lDescripcion.Text = "Descripción";
            // 
            // lCantCamas
            // 
            lCantCamas.AutoSize = true;
            lCantCamas.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lCantCamas.ForeColor = Color.DarkSlateGray;
            lCantCamas.Location = new Point(30, 153);
            lCantCamas.Name = "lCantCamas";
            lCantCamas.Size = new Size(137, 20);
            lCantCamas.TabIndex = 2;
            lCantCamas.Text = "Cantidad de camas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(30, 80);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(22, 30);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 0;
            label1.Text = "Detalles";
            // 
            // TipoHabitacionView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(759, 618);
            Controls.Add(tNuevaHabitación);
            Controls.Add(lTipoHabit);
            Controls.Add(panel1);
            Name = "TipoHabitacionView";
            Text = "TipoHabitacionView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tNuevaHabitación.ResumeLayout(false);
            tTodos.ResumeLayout(false);
            tTodos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tDoble.ResumeLayout(false);
            tDoble.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tSuite.ResumeLayout(false);
            tSuite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            tNuevaHabit.ResumeLayout(false);
            tNuevaHabit.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lBuscarTipoHabit;
        private TextBox tbBuscarTipoHabit;
        private Label lTipoHabit;
        private TabControl tNuevaHabitación;
        private TabPage tTodos;
        private TabPage tabPage2;
        private TabPage tDoble;
        private TabPage tSuite;
        private TabPage tNuevaHabit;
        private Label label1;
        private Label lTodos;
        private Label lIndividual;
        private Label lDoble;
        private Label lSuite;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnaTipo;
        private DataGridViewTextBoxColumn ColumnaCamas;
        private DataGridViewTextBoxColumn ColumnaDescripcion;
        private DataGridViewButtonColumn ColumnaEditar;
        private DataGridViewButtonColumn ColumnaEliminar;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private DataGridViewButtonColumn dataGridViewButtonColumn2;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewButtonColumn dataGridViewButtonColumn3;
        private DataGridViewButtonColumn dataGridViewButtonColumn4;
        private DataGridView dataGridView4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewButtonColumn dataGridViewButtonColumn5;
        private DataGridViewButtonColumn dataGridViewButtonColumn6;
        private Label lDescripcion;
        private Label lCantCamas;
        private Label label2;
        private Button bCancelar;
        private Button bGuardar;
        private TextBox tbDescripcion;
        private TextBox tbCamas;
        private TextBox tbNombre;
    }
}