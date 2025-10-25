namespace ProyectoTaller_Lugo_Arias.Views
{
    partial class BackUpView
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
            lBackUp = new Label();
            lblRutaBackup = new Label();
            TRoute = new TextBox();
            BSave = new Button();
            BPath1 = new Button();
            lblArchivoRestore = new Label();
            TBPath = new TextBox();
            BPath2 = new Button();
            BRestore = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            tabControlSinCabecera1 = new TabControl();
            tabPage1 = new TabPage();
            BLogs = new Button();
            tabPage2 = new TabPage();
            BBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControlSinCabecera1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // lBackUp
            // 
            lBackUp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lBackUp.AutoSize = true;
            lBackUp.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lBackUp.ForeColor = Color.DarkSlateGray;
            lBackUp.Location = new Point(338, 30);
            lBackUp.Name = "lBackUp";
            lBackUp.Size = new Size(97, 32);
            lBackUp.TabIndex = 3;
            lBackUp.Text = "Backup";
            // 
            // lblRutaBackup
            // 
            lblRutaBackup.AutoSize = true;
            lblRutaBackup.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRutaBackup.ForeColor = Color.DarkSlateGray;
            lblRutaBackup.Location = new Point(222, 26);
            lblRutaBackup.Name = "lblRutaBackup";
            lblRutaBackup.Size = new Size(289, 25);
            lblRutaBackup.TabIndex = 4;
            lblRutaBackup.Text = "RUTA PARA GUARDAR BACK UP";
            // 
            // TRoute
            // 
            TRoute.BackColor = SystemColors.Control;
            TRoute.Location = new Point(222, 66);
            TRoute.Name = "TRoute";
            TRoute.Size = new Size(289, 29);
            TRoute.TabIndex = 10;
            // 
            // BSave
            // 
            BSave.BackColor = Color.DarkSlateGray;
            BSave.FlatAppearance.BorderSize = 0;
            BSave.FlatStyle = FlatStyle.Flat;
            BSave.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BSave.ForeColor = SystemColors.InactiveBorder;
            BSave.Location = new Point(306, 111);
            BSave.Name = "BSave";
            BSave.Size = new Size(146, 31);
            BSave.TabIndex = 11;
            BSave.Text = "Crear backup";
            BSave.UseVisualStyleBackColor = false;
            // 
            // BPath1
            // 
            BPath1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BPath1.ForeColor = Color.DarkSlateGray;
            BPath1.Location = new Point(545, 65);
            BPath1.Name = "BPath1";
            BPath1.Size = new Size(146, 31);
            BPath1.TabIndex = 12;
            BPath1.Text = "Buscar carpeta...";
            BPath1.UseVisualStyleBackColor = true;
            BPath1.Click += BPath1_Click;
            // 
            // lblArchivoRestore
            // 
            lblArchivoRestore.AutoSize = true;
            lblArchivoRestore.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblArchivoRestore.ForeColor = Color.DarkSlateGray;
            lblArchivoRestore.Location = new Point(222, 171);
            lblArchivoRestore.Name = "lblArchivoRestore";
            lblArchivoRestore.Size = new Size(268, 25);
            lblArchivoRestore.TabIndex = 13;
            lblArchivoRestore.Text = "SELECCIONAR ARCHIVO .BAK";
            // 
            // TBPath
            // 
            TBPath.BackColor = SystemColors.Control;
            TBPath.Location = new Point(222, 214);
            TBPath.Name = "TBPath";
            TBPath.Size = new Size(289, 29);
            TBPath.TabIndex = 14;
            // 
            // BPath2
            // 
            BPath2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BPath2.ForeColor = Color.DarkSlateGray;
            BPath2.Location = new Point(545, 213);
            BPath2.Name = "BPath2";
            BPath2.Size = new Size(146, 31);
            BPath2.TabIndex = 15;
            BPath2.Text = "Buscar archivo...";
            BPath2.UseVisualStyleBackColor = true;
            BPath2.Click += BPath2_Click;
            // 
            // BRestore
            // 
            BRestore.BackColor = Color.DarkSlateGray;
            BRestore.FlatAppearance.BorderSize = 0;
            BRestore.FlatStyle = FlatStyle.Flat;
            BRestore.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BRestore.ForeColor = SystemColors.InactiveBorder;
            BRestore.Location = new Point(306, 258);
            BRestore.Name = "BRestore";
            BRestore.Size = new Size(146, 31);
            BRestore.TabIndex = 16;
            BRestore.Text = "Restaurar";
            BRestore.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(16, 21);
            label1.Name = "label1";
            label1.Size = new Size(221, 25);
            label1.TabIndex = 17;
            label1.Text = "HISTORIAL DE BACKUPS";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(642, 288);
            dataGridView1.TabIndex = 18;
            // 
            // tabControlSinCabecera1
            // 
            tabControlSinCabecera1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlSinCabecera1.Controls.Add(tabPage1);
            tabControlSinCabecera1.Controls.Add(tabPage2);
            tabControlSinCabecera1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControlSinCabecera1.Location = new Point(-1, 100);
            tabControlSinCabecera1.Name = "tabControlSinCabecera1";
            tabControlSinCabecera1.SelectedIndex = 0;
            tabControlSinCabecera1.Size = new Size(802, 357);
            tabControlSinCabecera1.TabIndex = 19;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Control;
            tabPage1.Controls.Add(BLogs);
            tabPage1.Controls.Add(lblRutaBackup);
            tabPage1.Controls.Add(BRestore);
            tabPage1.Controls.Add(TRoute);
            tabPage1.Controls.Add(BPath2);
            tabPage1.Controls.Add(BPath1);
            tabPage1.Controls.Add(TBPath);
            tabPage1.Controls.Add(BSave);
            tabPage1.Controls.Add(lblArchivoRestore);
            tabPage1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(794, 323);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "BackUp";
            // 
            // BLogs
            // 
            BLogs.BackColor = Color.DarkSlateGray;
            BLogs.FlatAppearance.BorderSize = 0;
            BLogs.FlatStyle = FlatStyle.Flat;
            BLogs.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BLogs.ForeColor = SystemColors.InactiveBorder;
            BLogs.Location = new Point(657, 312);
            BLogs.Name = "BLogs";
            BLogs.Size = new Size(99, 31);
            BLogs.TabIndex = 19;
            BLogs.Text = "Historial";
            BLogs.UseVisualStyleBackColor = false;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.Control;
            tabPage2.Controls.Add(BBack);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 30);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(794, 323);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Historial";
            // 
            // BBack
            // 
            BBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BBack.Location = new Point(668, 67);
            BBack.Name = "BBack";
            BBack.Size = new Size(99, 31);
            BBack.TabIndex = 19;
            BBack.Text = "Backup";
            BBack.UseVisualStyleBackColor = true;
            // 
            // BackUpView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlSinCabecera1);
            Controls.Add(lBackUp);
            Name = "BackUpView";
            Text = "BackUpView";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControlSinCabecera1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lBackUp;
        private Label lblRutaBackup;
        private TextBox TRoute;
        private Button BSave;
        private Button BPath1;
        private Label lblArchivoRestore;
        private TextBox TBPath;
        private Button BPath2;
        private Button BRestore;
        private Label label1;
        private DataGridView dataGridView1;
        private TabControl tabControlSinCabecera1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button BLogs;
        private Button BBack;
    }
}