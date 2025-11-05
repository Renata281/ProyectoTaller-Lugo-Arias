namespace ProyectoTaller_Lugo_Arias.Views
{
    partial class ReportesView
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
            cbReportes = new ComboBox();
            dtpFechaInicio = new DateTimePicker();
            dtpFechaFin = new DateTimePicker();
            btnGenerarReporte = new Button();
            btnExportarPDF = new Button();
            lMotorEmpleados = new Label();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            dgvReportes = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
            SuspendLayout();
            // 
            // lBackUp
            // 
            lBackUp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lBackUp.AutoSize = true;
            lBackUp.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lBackUp.ForeColor = Color.DarkSlateGray;
            lBackUp.Location = new Point(337, 21);
            lBackUp.Name = "lBackUp";
            lBackUp.Size = new Size(116, 32);
            lBackUp.TabIndex = 4;
            lBackUp.Text = "Reportes";
            // 
            // cbReportes
            // 
            cbReportes.FormattingEnabled = true;
            cbReportes.Location = new Point(22, 96);
            cbReportes.Name = "cbReportes";
            cbReportes.Size = new Size(179, 23);
            cbReportes.TabIndex = 5;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.CalendarMonthBackground = SystemColors.Control;
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(217, 96);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(113, 23);
            dtpFechaInicio.TabIndex = 7;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.CalendarMonthBackground = SystemColors.Control;
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(353, 96);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(113, 23);
            dtpFechaFin.TabIndex = 8;
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.BackColor = Color.DarkSlateGray;
            btnGenerarReporte.FlatAppearance.BorderSize = 0;
            btnGenerarReporte.FlatStyle = FlatStyle.Flat;
            btnGenerarReporte.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerarReporte.ForeColor = SystemColors.InactiveBorder;
            btnGenerarReporte.Location = new Point(516, 91);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(128, 28);
            btnGenerarReporte.TabIndex = 12;
            btnGenerarReporte.Text = "Generar reporte";
            btnGenerarReporte.UseVisualStyleBackColor = false;
            // 
            // btnExportarPDF
            // 
            btnExportarPDF.BackColor = Color.DarkSlateGray;
            btnExportarPDF.FlatAppearance.BorderSize = 0;
            btnExportarPDF.FlatStyle = FlatStyle.Flat;
            btnExportarPDF.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportarPDF.ForeColor = SystemColors.InactiveBorder;
            btnExportarPDF.Location = new Point(664, 91);
            btnExportarPDF.Name = "btnExportarPDF";
            btnExportarPDF.Size = new Size(108, 28);
            btnExportarPDF.TabIndex = 13;
            btnExportarPDF.Text = "Exportar";
            btnExportarPDF.UseVisualStyleBackColor = false;
            btnExportarPDF.Click += btnExportarPDF_Click_1;
            // 
            // lMotorEmpleados
            // 
            lMotorEmpleados.AutoSize = true;
            lMotorEmpleados.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lMotorEmpleados.ForeColor = Color.DarkSlateGray;
            lMotorEmpleados.Location = new Point(22, 76);
            lMotorEmpleados.Name = "lMotorEmpleados";
            lMotorEmpleados.Size = new Size(59, 17);
            lMotorEmpleados.TabIndex = 14;
            lMotorEmpleados.Text = "Reporte:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(217, 76);
            label1.Name = "label1";
            label1.Size = new Size(48, 17);
            label1.TabIndex = 15;
            label1.Text = "Desde:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(353, 76);
            label2.Name = "label2";
            label2.Size = new Size(46, 17);
            label2.TabIndex = 16;
            label2.Text = "Hasta:";
            // 
            // panel1
            // 
            panel1.Controls.Add(lBackUp);
            panel1.Controls.Add(btnExportarPDF);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnGenerarReporte);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lMotorEmpleados);
            panel1.Controls.Add(cbReportes);
            panel1.Controls.Add(dtpFechaFin);
            panel1.Controls.Add(dtpFechaInicio);
            panel1.Location = new Point(1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 152);
            panel1.TabIndex = 17;
            // 
            // dgvReportes
            // 
            dgvReportes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReportes.BackgroundColor = SystemColors.Control;
            dgvReportes.BorderStyle = BorderStyle.None;
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportes.Location = new Point(1, 181);
            dgvReportes.Name = "dgvReportes";
            dgvReportes.Size = new Size(801, 266);
            dgvReportes.TabIndex = 18;
            // 
            // ReportesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvReportes);
            Controls.Add(panel1);
            Name = "ReportesView";
            RightToLeftLayout = true;
            Text = "Reportes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lBackUp;
        private ComboBox cbReportes;
        private DateTimePicker dtpFechaInicio;
        private DateTimePicker dtpFechaFin;
        private Button btnGenerarReporte;
        private Button btnExportarPDF;
        private Label lMotorEmpleados;
        private Label label1;
        private Label label2;
        private Panel panel1;
        // Elimina la declaración duplicada de dgvReportes en la sección #region Windows Form Designer generated code
        // Antes:
        // private DataGridView dgvReportes;
        // private DataGridView dgvReportes;

        // Después:
        private DataGridView dgvReportes;
    }
}