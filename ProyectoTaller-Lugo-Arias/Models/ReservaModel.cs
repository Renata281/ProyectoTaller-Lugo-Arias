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
    private int nro_habitacion;
    private int id_piso;
    private string estado;
    private int id_pago;
    private int cant_personas;
    private int id_tipo;

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

    [DisplayName("Estado")]
    public string Estado
    {
        get => estado;
        set => estado = value;
    }


    [DisplayName("ID Pago")]
    public int Id_pago
    {
        get => id_pago;
        set => id_pago = value;
    }

    [DisplayName("Cantidad de Personas")]
    [Required(ErrorMessage = "La cantidad de personas es obligatoria.")]
    [Range(1, 20, ErrorMessage = "La cantidad de personas debe ser entre 1 y 20.")]
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

    public void CalcularEstado()
    {
        var hoy = DateTime.Today;
        var ingreso = Fecha_ingreso.Date;
        var salida = Fecha_salida.Date;

        Estado = (ingreso, salida) switch
        {
            var (i, s) when s < hoy => "Finalizada",
            var (i, s) when i <= hoy && s >= hoy => "Activa",
            var (i, s) when i > hoy => "Pendiente",
            _ => "Desconocida"
        };
    }

    [DisplayName("ID Tipo Habitación")]
    [Required(ErrorMessage = "El ID del tipo de habitación es obligatorio.")]
    public int Id_tipo
    {
        get => id_tipo;
        set => id_tipo = value;
    }
}

