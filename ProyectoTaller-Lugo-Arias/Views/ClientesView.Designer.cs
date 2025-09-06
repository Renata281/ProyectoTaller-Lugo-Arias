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
            label1 = new Label();
            label8 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            BBuscar = new Button();
            label3 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            tabPage2 = new TabPage();
            dataGridView2 = new DataGridView();
            label5 = new Label();
            tabPage3 = new TabPage();
            dataGridView3 = new DataGridView();
            label6 = new Label();
            tabPage4 = new TabPage();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewImageColumn();
            Eliminar = new DataGridViewImageColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewImageColumn();
            Column6 = new DataGridViewImageColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewImageColumn();
            Column7 = new DataGridViewImageColumn();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            TNombre = new TextBox();
            TDni = new TextBox();
            TEmail = new TextBox();
            TTelefono = new TextBox();
            BGuardar = new Button();
            BCancelar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tabControl1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(863, 547);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(269, 44);
            label1.Name = "label1";
            label1.Size = new Size(0, 30);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(33, 24);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 4;
            label8.Text = "Buscar";
            label8.Click += label8_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(BBuscar);
            panel2.Location = new Point(33, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(657, 32);
            panel2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 9);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 2;
            label2.Text = "Buscar cliente...";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(249, 115);
            label3.Name = "label3";
            label3.Size = new Size(210, 30);
            label3.TabIndex = 6;
            label3.Text = "Clientes Registrados";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(3, 160);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(840, 387);
            tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(label4);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(832, 359);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Todos";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Eliminar });
            dataGridView1.Location = new Point(0, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(832, 314);
            dataGridView1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(26, 21);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 0;
            label4.Text = "Lista de clientes";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(label5);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(832, 359);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Activos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, Column6 });
            dataGridView2.Location = new Point(0, 51);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(832, 309);
            dataGridView2.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(26, 23);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 1;
            label5.Text = "Lista de clientes";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Controls.Add(label6);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(832, 359);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Inactivos";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12, Column7 });
            dataGridView3.Location = new Point(0, 48);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(832, 312);
            dataGridView3.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(23, 17);
            label6.Name = "label6";
            label6.Size = new Size(95, 15);
            label6.TabIndex = 1;
            label6.Text = "Lista de clientes";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(BCancelar);
            tabPage4.Controls.Add(BGuardar);
            tabPage4.Controls.Add(TTelefono);
            tabPage4.Controls.Add(TEmail);
            tabPage4.Controls.Add(TDni);
            tabPage4.Controls.Add(TNombre);
            tabPage4.Controls.Add(label12);
            tabPage4.Controls.Add(label11);
            tabPage4.Controls.Add(label10);
            tabPage4.Controls.Add(label9);
            tabPage4.Controls.Add(label7);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(832, 359);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Nuevo Cliente";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre y Apellido";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Email";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Telefono";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Estado";
            Column4.Name = "Column4";
            Column4.Resizable = DataGridViewTriState.True;
            // 
            // Column5
            // 
            Column5.HeaderText = "Editar";
            Column5.Image = Properties.Resources.editar;
            Column5.Name = "Column5";
            Column5.Resizable = DataGridViewTriState.True;
            Column5.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Image = Properties.Resources.eliminar;
            Eliminar.Name = "Eliminar";
            Eliminar.Resizable = DataGridViewTriState.True;
            Eliminar.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Nombre y Apellido";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Email";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Telefono";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Estado";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.Resizable = DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Editar";
            dataGridViewTextBoxColumn10.Image = Properties.Resources.editar;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.Resizable = DataGridViewTriState.True;
            dataGridViewTextBoxColumn10.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Column6
            // 
            Column6.HeaderText = "Eliminar";
            Column6.Image = Properties.Resources.eliminar;
            Column6.Name = "Column6";
            Column6.Resizable = DataGridViewTriState.True;
            Column6.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Nombre y Apellido";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Email";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Telefono";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.HeaderText = "Estado";
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.Resizable = DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.HeaderText = "Editar";
            dataGridViewTextBoxColumn12.Image = Properties.Resources.editar;
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.Resizable = DataGridViewTriState.True;
            dataGridViewTextBoxColumn12.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Column7
            // 
            Column7.HeaderText = "Eliminar";
            Column7.Image = Properties.Resources.eliminar;
            Column7.Name = "Column7";
            Column7.Resizable = DataGridViewTriState.True;
            Column7.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(6, 17);
            label7.Name = "label7";
            label7.Size = new Size(101, 15);
            label7.TabIndex = 0;
            label7.Text = "Datos Personales";
            label7.Click += label7_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(7, 45);
            label9.Name = "label9";
            label9.Size = new Size(110, 15);
            label9.TabIndex = 1;
            label9.Text = "Nombre y Apellido:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 113);
            label10.Name = "label10";
            label10.Size = new Size(142, 15);
            label10.TabIndex = 2;
            label10.Text = "Documento de Identidad:";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(7, 178);
            label11.Name = "label11";
            label11.Size = new Size(39, 15);
            label11.TabIndex = 3;
            label11.Text = "Email:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(7, 246);
            label12.Name = "label12";
            label12.Size = new Size(56, 15);
            label12.TabIndex = 4;
            label12.Text = "Telefono:";
            label12.Click += label12_Click;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(7, 73);
            TNombre.Multiline = true;
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(643, 23);
            TNombre.TabIndex = 5;
            // 
            // TDni
            // 
            TDni.Location = new Point(7, 140);
            TDni.Multiline = true;
            TDni.Name = "TDni";
            TDni.Size = new Size(643, 23);
            TDni.TabIndex = 6;
            // 
            // TEmail
            // 
            TEmail.Location = new Point(7, 210);
            TEmail.Multiline = true;
            TEmail.Name = "TEmail";
            TEmail.Size = new Size(643, 23);
            TEmail.TabIndex = 7;
            // 
            // TTelefono
            // 
            TTelefono.Location = new Point(7, 274);
            TTelefono.Multiline = true;
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(643, 23);
            TTelefono.TabIndex = 8;
            // 
            // BGuardar
            // 
            BGuardar.BackColor = Color.DodgerBlue;
            BGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BGuardar.ForeColor = SystemColors.ControlLightLight;
            BGuardar.Location = new Point(226, 303);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(81, 34);
            BGuardar.TabIndex = 9;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = false;
            // 
            // BCancelar
            // 
            BCancelar.BackColor = SystemColors.GradientActiveCaption;
            BCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BCancelar.ForeColor = Color.RoyalBlue;
            BCancelar.Location = new Point(328, 303);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(81, 34);
            BCancelar.TabIndex = 10;
            BCancelar.Text = "Cancelar";
            BCancelar.UseVisualStyleBackColor = false;
            // 
            // ClientesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 533);
            Controls.Add(panel1);
            Name = "ClientesView";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label8;
        private Panel panel2;
        private Label label2;
        private Button BBuscar;
        private Label label3;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private Label label4;
        private TabPage tabPage2;
        private DataGridView dataGridView2;
        private Label label5;
        private TabPage tabPage3;
        private DataGridView dataGridView3;
        private Label label6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewImageColumn Column5;
        private DataGridViewImageColumn Eliminar;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewImageColumn dataGridViewTextBoxColumn10;
        private DataGridViewImageColumn Column6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewImageColumn dataGridViewTextBoxColumn12;
        private DataGridViewImageColumn Column7;
        private TabPage tabPage4;
        private Label label7;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox TNombre;
        private TextBox TEmail;
        private TextBox TDni;
        private TextBox TTelefono;
        private Button BCancelar;
        private Button BGuardar;
    }
}