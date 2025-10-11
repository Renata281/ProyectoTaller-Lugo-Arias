using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public class ReservaModel
{
    private int nro_reserva;
    private DateTime fecha_ingreso;
    private DateTime fecha_salida;
    private decimal monto_total;
    private int id_cliente;
    private int dni;
    private int nro_habitacion;
    private int id_piso;
    private string estado;
    private int id_pago;
    private string pago_descripcion;
    private int cant_personas;

    [DisplayName("ID Reserva")]
    public int Nro_reserva
    {
        get => nro_reserva;
        set => nro_reserva = value;
    }

    [DisplayName("Fecha Ingreso")]
    [Required(ErrorMessage = "La fecha de ingreso es obligatoria.")]
    [DataType(DataType.Date)]
    public DateTime Fecha_ingreso
    {
        get => fecha_ingreso;
        set => fecha_ingreso = value;
    }

    [DisplayName("Fecha Egreso")]
    [Required(ErrorMessage = "La fecha de egreso es obligatoria.")]
    [DataType(DataType.Date)]
    public DateTime Fecha_salida
    {
        get => fecha_salida;
        set => fecha_salida = value;
    }

    [DisplayName("Monto Total")]
    public decimal Monto_total
    {
        get => monto_total;
        set => monto_total = value;
    }

    [DisplayName("ID Habitación")]
    [Required(ErrorMessage = "El ID de la habitación es obligatorio.")]
    public int Nro_habitacion
    {
        get => nro_habitacion;
        set => nro_habitacion = value;
    }

    public int Id_piso
    {
        get => id_piso;
        set => id_piso = value;
    }

    [DisplayName("ID Cliente")]
    [Required(ErrorMessage = "El ID del cliente es obligatorio.")]
    public int Id_cliente
    {
        get => id_cliente;
        set => id_cliente = value;
    }

    public int Dni
    {
        get => dni;
        set => dni = value;
    }

    public string Estado
    {
        get
        {
            if (!string.IsNullOrEmpty(estado))
                return estado; // Si fue seteado manualmente, respetarlo

            DateTime hoy = DateTime.Now.Date;

            if (hoy < Fecha_ingreso.Date)
                return "Pendiente";
            else if (hoy >= Fecha_ingreso.Date && hoy < Fecha_salida.Date)
                return "Activa";
            else
                return "Finalizada";
        }
        set => estado = value;
    }


    [DisplayName("ID Pago")]
    public int Id_pago
    {
        get => id_pago;
        set => id_pago = value;
    }

    [DisplayName("Descripción del Pago")]
    public string Pago_descripcion
    {
        get => pago_descripcion;
        set => pago_descripcion = value;
    }

    public int Cant_personas
    {
        get => cant_personas;
        set => cant_personas = value;
    }

    public void ValidarFechas()
    {
        if (Fecha_salida <= Fecha_ingreso)
            throw new ValidationException("La fecha de salida debe ser posterior a la fecha de ingreso.");
    }
}

