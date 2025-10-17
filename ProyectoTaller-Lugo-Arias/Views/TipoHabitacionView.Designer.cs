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
            bBuscar = new Button();
            lBuscarTipoHabit = new Label();
            txtSearch = new TextBox();
            lTipoHabit = new Label();
            tTipoHabitacion = new TabControl();
            tTodos = new TabPage();
            bEliminar = new Button();
            bEditar = new Button();
            bNuevo = new Button();
            dataGridView1 = new DataGridView();
            lTodos = new Label();
            tNuevaHabit = new TabPage();
            bCancelar = new Button();
            bGuardar = new Button();
            tbDescripcion = new TextBox();
            tbNombre = new TextBox();
            lDescripcion = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            tTipoHabitacion.SuspendLayout();
            tTodos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tNuevaHabit.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(bBuscar);
            panel1.Controls.Add(lBuscarTipoHabit);
            panel1.Controls.Add(txtSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(790, 84);
            panel1.TabIndex = 0;
            // 
            // bBuscar
            // 
            bBuscar.Location = new Point(640, 44);
            bBuscar.Name = "bBuscar";
            bBuscar.Size = new Size(75, 23);
            bBuscar.TabIndex = 3;
            bBuscar.Text = "Buscar";
            bBuscar.UseVisualStyleBackColor = true;
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
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.Control;
            txtSearch.Location = new Point(34, 44);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(579, 23);
            txtSearch.TabIndex = 0;
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
            lTipoHabit.TextAlign = ContentAlignment.TopCenter;
            // 
            // tTipoHabitacion
            // 
            tTipoHabitacion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tTipoHabitacion.Controls.Add(tTodos);
            tTipoHabitacion.Controls.Add(tNuevaHabit);
            tTipoHabitacion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tTipoHabitacion.Location = new Point(0, 153);
            tTipoHabitacion.Name = "tTipoHabitacion";
            tTipoHabitacion.SelectedIndex = 0;
            tTipoHabitacion.Size = new Size(790, 389);
            tTipoHabitacion.TabIndex = 3;
            // 
            // tTodos
            // 
            tTodos.BackColor = SystemColors.Control;
            tTodos.Controls.Add(bEliminar);
            tTodos.Controls.Add(bEditar);
            tTodos.Controls.Add(bNuevo);
            tTodos.Controls.Add(dataGridView1);
            tTodos.Controls.Add(lTodos);
            tTodos.Location = new Point(4, 30);
            tTodos.Name = "tTodos";
            tTodos.Padding = new Padding(3);
            tTodos.Size = new Size(782, 355);
            tTodos.TabIndex = 0;
            tTodos.Text = "Tipos Habitación";
            // 
            // bEliminar
            // 
            bEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bEliminar.Location = new Point(660, 198);
            bEliminar.Name = "bEliminar";
            bEliminar.Size = new Size(99, 31);
            bEliminar.TabIndex = 10;
            bEliminar.Text = "Eliminar";
            bEliminar.UseVisualStyleBackColor = true;
            // 
            // bEditar
            // 
            bEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bEditar.Location = new Point(660, 136);
            bEditar.Name = "bEditar";
            bEditar.Size = new Size(99, 31);
            bEditar.TabIndex = 9;
            bEditar.Text = "Editar";
            bEditar.UseVisualStyleBackColor = true;
            // 
            // bNuevo
            // 
            bNuevo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bNuevo.Location = new Point(660, 73);
            bNuevo.Name = "bNuevo";
            bNuevo.Size = new Size(99, 31);
            bNuevo.TabIndex = 7;
            bNuevo.Text = "Nuevo";
            bNuevo.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(640, 279);
            dataGridView1.TabIndex = 2;
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
            // tNuevaHabit
            // 
            tNuevaHabit.BackColor = SystemColors.Control;
            tNuevaHabit.Controls.Add(bCancelar);
            tNuevaHabit.Controls.Add(bGuardar);
            tNuevaHabit.Controls.Add(tbDescripcion);
            tNuevaHabit.Controls.Add(tbNombre);
            tNuevaHabit.Controls.Add(lDescripcion);
            tNuevaHabit.Controls.Add(label2);
            tNuevaHabit.Controls.Add(label1);
            tNuevaHabit.Location = new Point(4, 30);
            tNuevaHabit.Name = "tNuevaHabit";
            tNuevaHabit.Padding = new Padding(3);
            tNuevaHabit.Size = new Size(782, 355);
            tNuevaHabit.TabIndex = 4;
            tNuevaHabit.Text = "Nueva habitación";
            // 
            // bCancelar
            // 
            bCancelar.BackColor = SystemColors.InactiveCaption;
            bCancelar.FlatAppearance.BorderSize = 0;
            bCancelar.FlatStyle = FlatStyle.Flat;
            bCancelar.ForeColor = Color.DarkSlateGray;
            bCancelar.Location = new Point(365, 323);
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
            bGuardar.Location = new Point(235, 323);
            bGuardar.Name = "bGuardar";
            bGuardar.Size = new Size(92, 36);
            bGuardar.TabIndex = 7;
            bGuardar.Text = "Guardar";
            bGuardar.UseVisualStyleBackColor = false;
            // 
            // tbDescripcion
            // 
            tbDescripcion.BackColor = SystemColors.ButtonHighlight;
            tbDescripcion.Location = new Point(220, 172);
            tbDescripcion.Multiline = true;
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.Size = new Size(252, 98);
            tbDescripcion.TabIndex = 6;
            // 
            // tbNombre
            // 
            tbNombre.BackColor = SystemColors.ButtonHighlight;
            tbNombre.Location = new Point(220, 95);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(252, 29);
            tbNombre.TabIndex = 4;
            // 
            // lDescripcion
            // 
            lDescripcion.AutoSize = true;
            lDescripcion.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lDescripcion.ForeColor = Color.DarkSlateGray;
            lDescripcion.Location = new Point(220, 149);
            lDescripcion.Name = "lDescripcion";
            lDescripcion.Size = new Size(89, 20);
            lDescripcion.TabIndex = 3;
            lDescripcion.Text = "Descripción";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(220, 72);
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
            ClientSize = new Size(790, 542);
            Controls.Add(tTipoHabitacion);
            Controls.Add(lTipoHabit);
            Controls.Add(panel1);
            Name = "TipoHabitacionView";
            Text = "TipoHabitacionView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tTipoHabitacion.ResumeLayout(false);
            tTodos.ResumeLayout(false);
            tTodos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tNuevaHabit.ResumeLayout(false);
            tNuevaHabit.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lBuscarTipoHabit;
        private TextBox txtSearch;
        private Label lTipoHabit;
        private TabControl tTipoHabitacion;
        private TabPage tTodos;
        private TabPage tNuevaHabit;
        private Label label1;
        private Label lTodos;
        private DataGridView dataGridView1;
        private Label lDescripcion;
        private Label label2;
        private Button bCancelar;
        private Button bGuardar;
        private TextBox tbDescripcion;
        private TextBox tbNombre;
        private Button bBuscar;
        private Button bEliminar;
        private Button bEditar;
        private Button bNuevo;
    }
}