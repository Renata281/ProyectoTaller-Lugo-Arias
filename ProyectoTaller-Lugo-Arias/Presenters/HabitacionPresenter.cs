using ProyectoTaller_Lugo_Arias.Models;
using ProyectoTaller_Lugo_Arias.View;
using ProyectoTaller_Lugo_Arias.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace ProyectoTaller_Lugo_Arias.Presenters;

public class HabitacionPresenter
{
    private IHabitacionesView view;
    private IHabitacionRepositorio repository;
    private BindingSource habitacionesBindingSource;
    private IEnumerable<HabitacionesModels> habList;
    private int AddNewHabitacion;

    public HabitacionPresenter(IHabitacionesView view, IHabitacionRepositorio repository)
    {
        this.habitacionesBindingSource = new BindingSource();
        this.view = view;
        this.repository = repository;
        this.view.SearchEvent += SearchHabitacion;
        this.view.AddNewEvent += AddNewHabitación;
        this.view.EditEvent += LoadSelectedHabitacionToEdit;
        this.view.DeleteEvent += DeleteSelectedHabitacion;
        this.view.SaveEvent += SaveHabitacion;
        this.view.CancelEvent += CancelAction;
        this.view.SetListaHabitacionesBindingSourse(habitacionesBindingSource);

        LoadAllHabitacionesList();
        this.view.Show();

    }

    private void SaveHabitacion(object? sender, EventArgs e)
    {
        var models = new HabitacionesModels();
        models.Nro_habitacion = Convert.ToInt32(view.Nro_habitacion);
        models.Cant_camas = Convert.ToInt32(view.Cant_camas);
        models.Precio_unitario = Convert.ToInt32(view.Precio_unitario);
        models.Descripcion = view.Descripcion;
        models.Tipo = view.Tipo;
        models.Id_piso = Convert.ToInt32(view.Id_piso);
        models.Id_estado = Convert.ToInt32(view.Id_estado);

        try
        {
            new common.ModelDataValidation().Validate(models);
            if (view.IsEdit)
            {
                repository.Edit(models);
                view.Message = "habitacion editada correctamente";
            }
            else
            {
                repository.Add(models);
                view.Message = "habitacion añadida correctamente";
            }
            view.IsSuccessful = true;
            LoadAllHabitacionesList();
            CleanviewFields();
        }
        catch(Exception ex)
        {
            view.IsSuccessful = false;
            view.Message = ex.Message;
        }
    }

    private void CleanviewFields()
    {
        view.Nro_habitacion = "0";
        view.Cant_camas = "0";
        view.Precio_unitario = "0";
        view.Descripcion = "";
        view.Tipo = "";
        view.Id_piso = "0";
        view.Id_estado = "0";
    }

    //metodo
    private void LoadAllHabitacionesList()
    {
        habList = repository.GetAll();
        habitacionesBindingSource.DataSource = habList;

    }

    private void CancelAction(object? sender, EventArgs e)
    {
        CleanviewFields();
    }

    private void DeleteSelectedHabitacion(object? sender, EventArgs e)
    {
        try
        {
            var hab = (HabitacionesModels)habitacionesBindingSource.Current;
            repository.Delete(hab.Nro_habitacion);
            view.IsSuccessful = true;
            view.Message = "habitacion eliminada correctamente";
            LoadAllHabitacionesList();
        }
        catch(Exception ex)
        {
            view.IsSuccessful = false;
            view.Message = "error";
        }
    }

    private void LoadSelectedHabitacionToEdit(object? sender, EventArgs e)
    {
        var hab = (HabitacionesModels)habitacionesBindingSource.Current;
        view.Nro_habitacion = hab.Nro_habitacion.ToString();
        view.Cant_camas = hab.Cant_camas.ToString();
        view.Precio_unitario = hab.Precio_unitario.ToString();
        view.Descripcion = hab.Descripcion;
        view.Tipo = hab.Tipo;
        view.Id_piso = hab.Id_piso.ToString();
        view.Id_estado = hab.Id_estado.ToString();
        view.IsEdit = true;
    }

    private void AddNewHabitación(object sender, EventArgs e)
    {
        view.IsEdit = false;
    }

    private void SearchHabitacion(object? sender, EventArgs e)
    {
        bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
        if (emptyValue == false)
            habList = repository.GetByValue(this.view.SearchValue);
        else habList = repository.GetValue();
        habitacionesBindingSource.DataSource = habList;
    }
}
