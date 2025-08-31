namespace ProyectoTaller_Lugo_Arias.Views
{
    partial class HabitacionesView
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
            BBuscar = new Button();
            BNotificaciones = new Button();
            label2 = new Label();
            panel2 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            habitacion = new DataGridViewTextBoxColumn();
            tipo = new DataGridViewTextBoxColumn();
            columna3 = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            editar = new DataGridViewImageColumn();
            eliminar = new DataGridViewImageColumn();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(BBuscar);
            panel1.Location = new Point(48, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(657, 32);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 2;
            label1.Text = "Buscar habitaciones...";
            // 
            // BBuscar
            // 
            BBuscar.ForeColor = Color.FromArgb(224, 224, 224);
            BBuscar.Image = Properties.Resources.lupa;
            BBuscar.Location = new Point(601, 0);
            BBuscar.Name = "BBuscar";
            BBuscar.Size = new Size(56, 32);
            BBuscar.TabIndex = 1;
            BBuscar.UseVisualStyleBackColor = true;
            // 
            // BNotificaciones
            // 
            BNotificaciones.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BNotificaciones.ForeColor = Color.Blue;
            BNotificaciones.Location = new Point(711, 50);
            BNotificaciones.Name = "BNotificaciones";
            BNotificaciones.Size = new Size(156, 33);
            BNotificaciones.TabIndex = 2;
            BNotificaciones.Text = "Notificaciones";
            BNotificaciones.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(51, 59);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 3;
            label2.Text = "Buscar";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(tabControl1);
            panel2.Controls.Add(BNotificaciones);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(-9, -38);
            panel2.Name = "panel2";
            panel2.Size = new Size(885, 501);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(21, 202);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(840, 274);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(832, 246);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Todas";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { habitacion, tipo, columna3, Estado, editar, eliminar });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(826, 240);
            dataGridView1.TabIndex = 4;
            // 
            // habitacion
            // 
            habitacion.HeaderText = "Habitación";
            habitacion.Name = "habitacion";
            // 
            // tipo
            // 
            tipo.HeaderText = "Tipo";
            tipo.Name = "tipo";
            // 
            // columna3
            // 
            columna3.HeaderText = "Estado";
            columna3.Name = "columna3";
            // 
            // Estado
            // 
            Estado.HeaderText = "Huéspedes";
            Estado.Name = "Estado";
            // 
            // editar
            // 
            editar.HeaderText = "";
            editar.Image = Properties.Resources.editar;
            editar.Name = "editar";
            editar.Resizable = DataGridViewTriState.True;
            editar.SortMode = DataGridViewColumnSortMode.Automatic;
            editar.Width = 30;
            // 
            // eliminar
            // 
            eliminar.HeaderText = "";
            eliminar.Image = Properties.Resources.eliminar;
            eliminar.Name = "eliminar";
            eliminar.Resizable = DataGridViewTriState.True;
            eliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            eliminar.Width = 30;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(832, 246);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Disponibles";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(832, 246);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Ocupadas";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(832, 246);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Mantenimiento";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(306, 131);
            label3.Name = "label3";
            label3.Size = new Size(248, 30);
            label3.TabIndex = 0;
            label3.Text = "Gestión de habitaciones";
            // 
            // HabitacionesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(864, 450);
            Controls.Add(panel2);
            ForeColor = SystemColors.ControlDarkDark;
            Name = "HabitacionesView";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BBuscar;
        private Button BNotificaciones;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn habitacion;
        private DataGridViewTextBoxColumn tipo;
        private DataGridViewTextBoxColumn columna3;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewImageColumn editar;
        private DataGridViewImageColumn eliminar;
    }
}