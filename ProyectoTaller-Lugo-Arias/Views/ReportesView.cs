using ProyectoTaller_Lugo_Arias.View;
using System;
using System.Data;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace ProyectoTaller_Lugo_Arias.Views
{
    public partial class ReportesView : Form, IReporteView
    {
        public ReportesView()
        {
            InitializeComponent();
            CrearControles();
            AsociarEventos();
        }

        private void CrearControles()
        {
            cbReportes.Items.AddRange(new string[]
            {
                "Habitaciones más reservadas",
                "Tipos de habitaciones más reservadas",
                "Facturación",
                "Pago más usado"
            });
        }

        private void AsociarEventos()
        {
            btnGenerarReporte.Click += (s, e) => GenerarReporteEvent?.Invoke(this, EventArgs.Empty);
            btnExportarPDF.Click += btnExportarPDF_Click_1;
        }

        // Filtros de fechas
        public DateTime FechaInicio
        {
            get => dtpFechaInicio.Value.Date;
            set => dtpFechaInicio.Value = value;
        }

        public DateTime FechaFin
        {
            get => dtpFechaFin.Value.Date;
            set => dtpFechaFin.Value = value;
        }

        // Reporte seleccionado
        public string ReporteSeleccionado
        {
            get => cbReportes.SelectedItem?.ToString() ?? string.Empty;
        }

        // Eventos
        public event EventHandler GenerarReporteEvent;

        // Mostrar tabla en el DataGridView
        public void LoadReport(DataTable tabla)
        {
            dgvReportes.DataSource = null;
            dgvReportes.Rows.Clear();
            dgvReportes.Columns.Clear();
            dgvReportes.DataSource = tabla;
        }

        // Mostrar mensajes
        public void ShowMessage(string mensaje)
        {
            MessageBox.Show(mensaje, "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExportarDataGridViewToPDF(DataTable dataSource, string fileName, string nombreReporte)
        {
            // Crear documento
            iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4, 10, 10, 40, 20);
            PdfWriter.GetInstance(doc, new FileStream(fileName, FileMode.Create));
            doc.Open();

            // Fuente para encabezado
            var tituloFont = FontFactory.GetFont("Arial", 20, iTextSharp.text.Font.BOLD, new BaseColor(System.Drawing.Color.DarkSlateGray));
            var subFont = FontFactory.GetFont("Arial", 13, iTextSharp.text.Font.NORMAL, new BaseColor(System.Drawing.Color.DarkSlateGray));

            // Encabezado
            Paragraph hotelName = new Paragraph("Hotel", tituloFont) { Alignment = Element.ALIGN_CENTER };
            doc.Add(hotelName);

            Paragraph reporte = new Paragraph($"Reporte: {nombreReporte}", subFont) { Alignment = Element.ALIGN_CENTER };
            doc.Add(reporte);

            Paragraph fechaGen = new Paragraph($"Fecha de generación: {DateTime.Now:dd/MM/yyyy}", subFont) { Alignment = Element.ALIGN_CENTER };
            doc.Add(fechaGen);

            Paragraph rangoFechas = new Paragraph($"Período evaluado: {FechaInicio:dd/MM/yyyy} - {FechaFin:dd/MM/yyyy}", subFont) { Alignment = Element.ALIGN_CENTER };
            doc.Add(rangoFechas);

            // Línea separadora
            doc.Add(new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_CENTER, 1))));
            doc.Add(new Paragraph(" ")); // Espacio

            // Tabla
            PdfPTable table = new PdfPTable(dataSource.Columns.Count) { WidthPercentage = 100 };

            // Colores
            BaseColor headerBackColor = new BaseColor(System.Drawing.SystemColors.InactiveCaption);
            BaseColor headerTextColor = new BaseColor(System.Drawing.Color.DarkSlateGray);

            // Cabeceras
            foreach (DataColumn column in dataSource.Columns)
            {
                PdfPCell headerCell = new PdfPCell(new Phrase(column.ColumnName, FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD, headerTextColor)))
                {
                    BackgroundColor = headerBackColor,
                    HorizontalAlignment = Element.ALIGN_CENTER
                };
                table.AddCell(headerCell);
            }

            // Filas
            foreach (DataRow row in dataSource.Rows)
            {
                foreach (var cell in row.ItemArray)
                {
                    PdfPCell dataCell = new PdfPCell(new Phrase(cell.ToString(), FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)))
                    {
                        HorizontalAlignment = Element.ALIGN_CENTER
                    };
                    table.AddCell(dataCell);
                }
            }

            doc.Add(table);
            doc.Close();
        }

        private void btnExportarPDF_Click_1(object sender, EventArgs e)
        {
            if (dgvReportes.DataSource == null)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            DataTable dt = (DataTable)dgvReportes.DataSource;

            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "Reporte.pdf";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    string nombreReporte = cbReportes.SelectedItem?.ToString() ?? "Reporte";
                    ExportarDataGridViewToPDF(dt, save.FileName, nombreReporte);
                    MessageBox.Show("PDF generado correctamente");
                }
            }
        }

        private static ReportesView instance;
        public static ReportesView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ReportesView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }
    }
}
