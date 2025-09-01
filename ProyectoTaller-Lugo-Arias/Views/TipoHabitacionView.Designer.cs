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
            tbBuscarTipoHabit = new TextBox();
            lBuscarTipoHabit = new Label();
            lTipoHabit = new Label();
            tNuevaHabitación = new TabControl();
            tTodos = new TabPage();
            tabPage2 = new TabPage();
            tDoble = new TabPage();
            tSuite = new TabPage();
            tNuevaHabit = new TabPage();
            label1 = new Label();
            lSuite = new Label();
            lDoble = new Label();
            lIndividual = new Label();
            lTodos = new Label();
            dataGridView1 = new DataGridView();
            ColumnaTipo = new DataGridViewTextBoxColumn();
            ColumnaCamas = new DataGridViewTextBoxColumn();
            ColumnaDescripcion = new DataGridViewTextBoxColumn();
            ColumnaEditar = new DataGridViewButtonColumn();
            ColumnaEliminar = new DataGridViewButtonColumn();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
            dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
            dataGridView3 = new DataGridView();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn3 = new DataGridViewButtonColumn();
            dataGridViewButtonColumn4 = new DataGridViewButtonColumn();
            dataGridView4 = new DataGridView();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn5 = new DataGridViewButtonColumn();
            dataGridViewButtonColumn6 = new DataGridViewButtonColumn();
            label2 = new Label();
            lCantCamas = new Label();
            lDescripcion = new Label();
            tbNombre = new TextBox();
            tbCamas = new TextBox();
            tbDescripcion = new TextBox();
            bGuardar = new Button();
            bCancelar = new Button();
            panel1.SuspendLayout();
            tNuevaHabitación.SuspendLayout();
            tTodos.SuspendLayout();
            tabPage2.SuspendLayout();
            tDoble.SuspendLayout();
            tSuite.SuspendLayout();
            tNuevaHabit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lBuscarTipoHabit);
            panel1.Controls.Add(tbBuscarTipoHabit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(762, 84);
            panel1.TabIndex = 0;
            // 
            // tbBuscarTipoHabit
            // 
            tbBuscarTipoHabit.Location = new Point(34, 44);
            tbBuscarTipoHabit.Name = "tbBuscarTipoHabit";
            tbBuscarTipoHabit.Size = new Size(579, 23);
            tbBuscarTipoHabit.TabIndex = 0;
            // 
            // lBuscarTipoHabit
            // 
            lBuscarTipoHabit.AutoSize = true;
            lBuscarTipoHabit.Location = new Point(34, 26);
            lBuscarTipoHabit.Name = "lBuscarTipoHabit";
            lBuscarTipoHabit.Size = new Size(92, 15);
            lBuscarTipoHabit.TabIndex = 1;
            lBuscarTipoHabit.Text = "Tipo Habitación";
            // 
            // lTipoHabit
            // 
            lTipoHabit.AutoSize = true;
            lTipoHabit.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lTipoHabit.Location = new Point(293, 108);
            lTipoHabit.Name = "lTipoHabit";
            lTipoHabit.Size = new Size(220, 30);
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
            tNuevaHabitación.Location = new Point(0, 164);
            tNuevaHabitación.Name = "tNuevaHabitación";
            tNuevaHabitación.SelectedIndex = 0;
            tNuevaHabitación.Size = new Size(762, 426);
            tNuevaHabitación.TabIndex = 3;
            // 
            // tTodos
            // 
            tTodos.Controls.Add(dataGridView1);
            tTodos.Controls.Add(lTodos);
            tTodos.Location = new Point(4, 24);
            tTodos.Name = "tTodos";
            tTodos.Padding = new Padding(3);
            tTodos.Size = new Size(754, 398);
            tTodos.TabIndex = 0;
            tTodos.Text = "Todos";
            tTodos.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(lIndividual);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(754, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Individual";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tDoble
            // 
            tDoble.Controls.Add(dataGridView3);
            tDoble.Controls.Add(lDoble);
            tDoble.Location = new Point(4, 24);
            tDoble.Name = "tDoble";
            tDoble.Padding = new Padding(3);
            tDoble.Size = new Size(754, 398);
            tDoble.TabIndex = 2;
            tDoble.Text = "Doble";
            tDoble.UseVisualStyleBackColor = true;
            // 
            // tSuite
            // 
            tSuite.Controls.Add(dataGridView4);
            tSuite.Controls.Add(lSuite);
            tSuite.Location = new Point(4, 24);
            tSuite.Name = "tSuite";
            tSuite.Padding = new Padding(3);
            tSuite.Size = new Size(754, 398);
            tSuite.TabIndex = 3;
            tSuite.Text = "Suite";
            tSuite.UseVisualStyleBackColor = true;
            // 
            // tNuevaHabit
            // 
            tNuevaHabit.Controls.Add(bCancelar);
            tNuevaHabit.Controls.Add(bGuardar);
            tNuevaHabit.Controls.Add(tbDescripcion);
            tNuevaHabit.Controls.Add(tbCamas);
            tNuevaHabit.Controls.Add(tbNombre);
            tNuevaHabit.Controls.Add(lDescripcion);
            tNuevaHabit.Controls.Add(lCantCamas);
            tNuevaHabit.Controls.Add(label2);
            tNuevaHabit.Controls.Add(label1);
            tNuevaHabit.Location = new Point(4, 24);
            tNuevaHabit.Name = "tNuevaHabit";
            tNuevaHabit.Padding = new Padding(3);
            tNuevaHabit.Size = new Size(754, 398);
            tNuevaHabit.TabIndex = 4;
            tNuevaHabit.Text = "Nueva habitación";
            tNuevaHabit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 16);
            label1.Name = "label1";
            label1.Size = new Size(65, 21);
            label1.TabIndex = 0;
            label1.Text = "Detalles";
            // 
            // lSuite
            // 
            lSuite.AutoSize = true;
            lSuite.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lSuite.Location = new Point(17, 18);
            lSuite.Name = "lSuite";
            lSuite.Size = new Size(179, 21);
            lSuite.TabIndex = 1;
            lSuite.Text = "Tipo de habitación: Suite";
            // 
            // lDoble
            // 
            lDoble.AutoSize = true;
            lDoble.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lDoble.Location = new Point(17, 24);
            lDoble.Name = "lDoble";
            lDoble.Size = new Size(185, 21);
            lDoble.TabIndex = 1;
            lDoble.Text = "Tipo de habitación: Doble";
            // 
            // lIndividual
            // 
            lIndividual.AutoSize = true;
            lIndividual.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lIndividual.Location = new Point(19, 16);
            lIndividual.Name = "lIndividual";
            lIndividual.Size = new Size(212, 21);
            lIndividual.TabIndex = 1;
            lIndividual.Text = "Tipo de habitación: Individual";
            // 
            // lTodos
            // 
            lTodos.AutoSize = true;
            lTodos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lTodos.Location = new Point(19, 16);
            lTodos.Name = "lTodos";
            lTodos.Size = new Size(213, 21);
            lTodos.TabIndex = 1;
            lTodos.Text = "Lista de tipos de habitaciones";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnaTipo, ColumnaCamas, ColumnaDescripcion, ColumnaEditar, ColumnaEliminar });
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(3, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(748, 332);
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
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewButtonColumn1, dataGridViewButtonColumn2 });
            dataGridView2.Dock = DockStyle.Bottom;
            dataGridView2.Location = new Point(3, 54);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(748, 341);
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
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewButtonColumn3, dataGridViewButtonColumn4 });
            dataGridView3.Dock = DockStyle.Bottom;
            dataGridView3.Location = new Point(3, 63);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(748, 332);
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
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewButtonColumn5, dataGridViewButtonColumn6 });
            dataGridView4.Dock = DockStyle.Bottom;
            dataGridView4.Location = new Point(3, 53);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.Size = new Size(748, 342);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 57);
            label2.Name = "label2";
            label2.Size = new Size(57, 17);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // lCantCamas
            // 
            lCantCamas.AutoSize = true;
            lCantCamas.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lCantCamas.Location = new Point(30, 120);
            lCantCamas.Name = "lCantCamas";
            lCantCamas.Size = new Size(120, 17);
            lCantCamas.TabIndex = 2;
            lCantCamas.Text = "Cantidad de camas";
            // 
            // lDescripcion
            // 
            lDescripcion.AutoSize = true;
            lDescripcion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lDescripcion.Location = new Point(30, 183);
            lDescripcion.Name = "lDescripcion";
            lDescripcion.Size = new Size(76, 17);
            lDescripcion.TabIndex = 3;
            lDescripcion.Text = "Descripción";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(30, 77);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(252, 23);
            tbNombre.TabIndex = 4;
            // 
            // tbCamas
            // 
            tbCamas.Location = new Point(30, 140);
            tbCamas.Name = "tbCamas";
            tbCamas.Size = new Size(252, 23);
            tbCamas.TabIndex = 5;
            // 
            // tbDescripcion
            // 
            tbDescripcion.Location = new Point(30, 214);
            tbDescripcion.Multiline = true;
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.Size = new Size(252, 98);
            tbDescripcion.TabIndex = 6;
            // 
            // bGuardar
            // 
            bGuardar.Location = new Point(517, 338);
            bGuardar.Name = "bGuardar";
            bGuardar.Size = new Size(92, 36);
            bGuardar.TabIndex = 7;
            bGuardar.Text = "Guardar";
            bGuardar.UseVisualStyleBackColor = true;
            // 
            // bCancelar
            // 
            bCancelar.Location = new Point(626, 338);
            bCancelar.Name = "bCancelar";
            bCancelar.Size = new Size(92, 36);
            bCancelar.TabIndex = 8;
            bCancelar.Text = "Cancelar";
            bCancelar.UseVisualStyleBackColor = true;
            // 
            // TipoHabitacionView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 590);
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
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tDoble.ResumeLayout(false);
            tDoble.PerformLayout();
            tSuite.ResumeLayout(false);
            tSuite.PerformLayout();
            tNuevaHabit.ResumeLayout(false);
            tNuevaHabit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
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