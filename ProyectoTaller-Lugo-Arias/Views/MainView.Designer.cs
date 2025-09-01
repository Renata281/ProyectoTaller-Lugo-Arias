namespace ProyectoTaller_Lugo_Arias.Views
{
    partial class MainView
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
            bSalir = new Button();
            bTipoHabitacion = new Button();
            bHabitaciones = new Button();
            bReservas = new Button();
            bClientes = new Button();
            lNombreHotel = new Label();
            bEmpleados = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(bSalir);
            panel1.Controls.Add(bTipoHabitacion);
            panel1.Controls.Add(bHabitaciones);
            panel1.Controls.Add(bReservas);
            panel1.Controls.Add(bClientes);
            panel1.Controls.Add(lNombreHotel);
            panel1.Controls.Add(bEmpleados);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(192, 450);
            panel1.TabIndex = 0;
            // 
            // bSalir
            // 
            bSalir.Location = new Point(0, 274);
            bSalir.Name = "bSalir";
            bSalir.Size = new Size(192, 41);
            bSalir.TabIndex = 6;
            bSalir.Text = "Salir";
            bSalir.UseVisualStyleBackColor = true;
            // 
            // bTipoHabitacion
            // 
            bTipoHabitacion.Location = new Point(0, 227);
            bTipoHabitacion.Name = "bTipoHabitacion";
            bTipoHabitacion.Size = new Size(192, 41);
            bTipoHabitacion.TabIndex = 5;
            bTipoHabitacion.Text = "Tipo de Habitación";
            bTipoHabitacion.UseVisualStyleBackColor = true;
            // 
            // bHabitaciones
            // 
            bHabitaciones.Location = new Point(0, 180);
            bHabitaciones.Name = "bHabitaciones";
            bHabitaciones.Size = new Size(192, 41);
            bHabitaciones.TabIndex = 4;
            bHabitaciones.Text = "Habitaciones";
            bHabitaciones.UseVisualStyleBackColor = true;
            // 
            // bReservas
            // 
            bReservas.Location = new Point(0, 133);
            bReservas.Name = "bReservas";
            bReservas.Size = new Size(192, 41);
            bReservas.TabIndex = 3;
            bReservas.Text = "Reservas";
            bReservas.UseVisualStyleBackColor = true;
            // 
            // bClientes
            // 
            bClientes.Location = new Point(0, 86);
            bClientes.Name = "bClientes";
            bClientes.Size = new Size(192, 41);
            bClientes.TabIndex = 2;
            bClientes.Text = "Clientes";
            bClientes.UseVisualStyleBackColor = true;
            // 
            // lNombreHotel
            // 
            lNombreHotel.AutoSize = true;
            lNombreHotel.Location = new Point(73, 10);
            lNombreHotel.Name = "lNombreHotel";
            lNombreHotel.Size = new Size(43, 15);
            lNombreHotel.TabIndex = 1;
            lNombreHotel.Text = "HOTEL";
            // 
            // bEmpleados
            // 
            bEmpleados.Location = new Point(0, 39);
            bEmpleados.Name = "bEmpleados";
            bEmpleados.Size = new Size(192, 41);
            bEmpleados.TabIndex = 0;
            bEmpleados.Text = "Empleados";
            bEmpleados.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "MainView";
            Text = "MainView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lNombreHotel;
        private Button bEmpleados;
        private Button bSalir;
        private Button bTipoHabitacion;
        private Button bHabitaciones;
        private Button bReservas;
        private Button bClientes;
    }
}