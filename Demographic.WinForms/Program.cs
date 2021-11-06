using Demographic.WinForms.Views.Interfaces;
using Demographic.WinForms.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demographic.WinForms
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IDemographicEmulationView view = new DemographicEmulationView();
            IEngine engine = new Engine();
            var presenter = new DemographicEmulationPresenter(view, engine);
            view.Show();

            Application.Run(view as DemographicEmulationView);
        }
    }
}
