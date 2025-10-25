using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using ProyectoTaller_Lugo_Arias.Models;

namespace ProyectoTaller_Lugo_Arias.Views
{
    public partial class BackUpView : Form, IBackUpView
    {
        private readonly FolderBrowserDialog dialog = new FolderBrowserDialog();
        private readonly OpenFileDialog openFile = new OpenFileDialog();

        public BackUpView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControlSinCabecera1.SelectedTab = tabPage1;
        }

        private void AssociateAndRaiseViewEvents()
        {
            //Generar BackUp
            BSave.Click += delegate { SaveEvent?.Invoke(this, EventArgs.Empty); };
            //Restaurar Base de Datos
            BRestore.Click += delegate { RestoreEvent?.Invoke(this, EventArgs.Empty); };
            //Ver historial
            BLogs.Click += delegate
            {
                tabControlSinCabecera1.SelectedTab = tabPage2;
            };
            // hacer back
            BBack.Click += delegate
            {
                tabControlSinCabecera1.SelectedTab = tabPage1;
            };
        }

        public void SetLogsListBindingSource(BindingSource logsList)
        {
            // Limpiar las columnas existentes (si es necesario)
            dataGridView1.Columns.Clear();
            // Configurar las columnas manualmente
            dataGridView1.AutoGenerateColumns = false; // Evita que se generen columnas automáticamente

            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.DataPropertyName = "Idlog"; // Nombre de la propiedad
            idColumn.HeaderText = "ID";
            idColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idColumn.FillWeight = 30;
            dataGridView1.Columns.Add(idColumn);
            // Crear y configurar la columna para filename
            DataGridViewTextBoxColumn fiColumn = new DataGridViewTextBoxColumn();
            fiColumn.DataPropertyName = "Archivo"; // Nombre de la propiedad
            fiColumn.HeaderText = "Archivo";
            //fiColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            fiColumn.Width = 40;
            dataGridView1.Columns.Add(fiColumn);

            // Crear y configurar la columna para DNI
            DataGridViewTextBoxColumn mailColumn = new DataGridViewTextBoxColumn();
            mailColumn.DataPropertyName = "UserEmail"; // Nombre de la propiedad
            mailColumn.HeaderText = "Mail";
            //mailColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            mailColumn.Width = 50;
            dataGridView1.Columns.Add(mailColumn);

            // Crear y configurar la columna para FirstName
            DataGridViewTextBoxColumn dateNameColumn = new DataGridViewTextBoxColumn();
            dateNameColumn.DataPropertyName = "Fecha"; // Nombre de la propiedad
            dateNameColumn.HeaderText = "Fecha";
            //dateNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dateNameColumn.Width = 50;
            //mailColumn.FillWeight = 30;

            dataGridView1.Columns.Add(dateNameColumn);

            // Asignar el DataSource
            //new BindingSource(logsList, null)
            dataGridView1.DataSource = logsList;

        }

        public event EventHandler SaveEvent;
        public event EventHandler RestoreEvent;

        public string SavePath
        {
            get { return TRoute.Text; }
            set { TRoute.Text = value; }
        }
        public string RestorePath
        {
            get { return TBPath.Text; }
            set { TBPath.Text = value; }
        }

        private static BackUpView instance;
        public static BackUpView GetInstance(Form parentContainer)
        {

            if (instance == null || instance.IsDisposed)
            {
                instance = new BackUpView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            instance.tabControlSinCabecera1.SelectedTab = instance.tabPage1;
            return instance;


        }

        private void BPath1_Click(object sender, EventArgs e)
        {
            dialog.Description = "Seleccione una carpeta";
            dialog.ShowNewFolderButton = true;  // Permitir crear nuevas carpetas

            // Mostrar el diálogo y verificar si el usuario selecciona una carpeta
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta de la carpeta seleccionada
                string selectedFolder = dialog.SelectedPath;

                // Mostrar la ruta en un MessageBox o asignarla a un TextBox
                TRoute.Text = selectedFolder;
            }
        }

        private void BPath2_Click(object sender, EventArgs e)
        {
            openFile.Filter = "Restore files (*.bak)|*.bak";
            openFile.ShowDialog();
            RestorePath = openFile.FileName;
        }
    }
}

