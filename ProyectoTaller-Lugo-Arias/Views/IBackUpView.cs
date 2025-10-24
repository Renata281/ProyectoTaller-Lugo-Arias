using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoTaller_Lugo_Arias.Models;

namespace ProyectoTaller_Lugo_Arias.Views
{
    public interface IBackUpView
    {
            string SavePath { get; set; }
            string RestorePath { get; set; }
            event EventHandler SaveEvent;
            event EventHandler RestoreEvent;
            void SetLogsListBindingSource(BindingSource LogsList);
            void Show();
        
    }
}
