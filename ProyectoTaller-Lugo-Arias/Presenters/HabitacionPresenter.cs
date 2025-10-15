using ProyectoTaller_Lugo_Arias.Models;
using ProyectoTaller_Lugo_Arias.Repositorio;
using ProyectoTaller_Lugo_Arias.Repositorio;
using ProyectoTaller_Lugo_Arias.View;
using ProyectoTaller_Lugo_Arias.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProyectoTaller_Lugo_Arias.Presenters
{

    public class HabitacionPresenter
    {
        //campos
        private IHabitacionView view;
        private IHabitacionRepositorio repository;
        private BindingSource habitacionesBindingSource;
        private IEnumerable<HabitacionesModels> habList;
        private IPisoRepositorio pisoRepositorio;
        private IEstadoHabitacionRepositorio estadoHabitacionRepositorio;
        private ITipoHabitacionRepositorio tipoHabitacionRepositorio;
        //
        private BindingSource habitacionesBindingSourceDisponibles;
        private IEnumerable<HabitacionesModels> habListDisponibles;
        private BindingSource habitacionesBindingSourceOcupadas;
        private IEnumerable<HabitacionesModels> habListOcupadas;
        private BindingSource habitacionesBindingSourceMantenimiento;
        private IEnumerable<HabitacionesModels> habListMantenimiento;

        public HabitacionPresenter(IHabitacionView view, IHabitacionRepositorio repository, IPisoRepositorio pisoRepositorio, IEstadoHabitacionRepositorio estadoHabitacionRepositorio, ITipoHabitacionRepositorio tipoHabitacionRepositorio)
        {
            this.habitacionesBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;
            this.habitacionesBindingSourceDisponibles = new BindingSource();
            this.habitacionesBindingSourceOcupadas = new BindingSource();
            this.habitacionesBindingSourceMantenimiento = new BindingSource();


            this.view.SearchEvent += SearchHabitacion;
            this.view.AddNewEvent += AddNewHabitación;
            this.view.EditEvent += LoadSelectedHabitacionToEdit;
            this.view.DeleteEvent += DeleteSelectedHabitacion;
            this.view.SaveEvent += SaveHabitacion;
            this.view.CancelEvent += CancelAction;

            this.view.SetListaHabitacionBindingSourse(habitacionesBindingSource);
            this.view.SetListaHabitacionBindingSourseDisponibles(habitacionesBindingSourceDisponibles);
            this.view.SetListaHabitacionBindingSourseOcupadas(habitacionesBindingSourceOcupadas);
            this.view.SetListaHabitacionBindingSourseMantenimiento(habitacionesBindingSourceMantenimiento);

            this.view.SetPisosListComboBox(pisoRepositorio.GetAll());
            this.view.SetEstadoHabitacionListComboBox(estadoHabitacionRepositorio.GetAll());
            this.view.SetTipoHabitacionListComboBox(tipoHabitacionRepositorio.GetAll());

            LoadAllHabitacionesList();
            this.view.Show();
            
        }

        private void SaveHabitacion(object? sender, EventArgs e)
        {
            var models = new HabitacionesModels();

            models.Nro_habitacion = string.IsNullOrWhiteSpace(view.Nro_habitacion) ? 0 : Convert.ToInt32(view.Nro_habitacion);
            models.Cant_camas = string.IsNullOrWhiteSpace(view.Cant_camas) ? 0 : Convert.ToInt32(view.Cant_camas);
            models.Precio_unitario = string.IsNullOrWhiteSpace(view.Precio_unitario) ? 0f : Convert.ToSingle(view.Precio_unitario);
            models.Descripcion = view.Descripcion ?? string.Empty;
            models.Tipo = view.Tipo ?? string.Empty;
            models.Id_piso = string.IsNullOrWhiteSpace(view.Id_piso) ? 0 : Convert.ToInt32(view.Id_piso);
            models.Id_estado = string.IsNullOrWhiteSpace(view.Id_estado) ? 0 : Convert.ToInt32(view.Id_estado);

            try
            {
                new Common.ModelDataValidation().Validate(models);

                if (view.IsEdit)
                {
                    repository.Edit(models);
                    view.Message = "Habitación editada correctamente.";
                }
                else
                {
                    repository.Add(models);
                    view.Message = "Habitación añadida correctamente.";
                }

                view.IsSuccessful = true;
                LoadAllHabitacionesList();
                CleanviewFields();
            }
            catch (Exception ex)
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
            view.Id_piso = "1";
            view.Id_estado = "1";
            view.Cant_personas = "0";
        }

        //metodo
        private void LoadAllHabitacionesList()
        {
            habList = repository.GetAll();
            habitacionesBindingSource.DataSource = habList;

            habListDisponibles = repository.GetAll();
            habitacionesBindingSourceDisponibles.DataSource = habListDisponibles;
            habListOcupadas = repository.GetAll();
            habitacionesBindingSourceOcupadas.DataSource = habListOcupadas;
            habListMantenimiento = repository.GetAll();
            habitacionesBindingSourceMantenimiento.DataSource = habListMantenimiento;

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
                view.Message = "Habitación eliminada correctamente";
                LoadAllHabitacionesList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "Ocurrio un error, no se puede eliminar la habitación";
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

            if (!emptyValue)
            {
                habList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                habList = repository.GetAll();
            }

            habitacionesBindingSource.DataSource = habList;
        }
    }
}
