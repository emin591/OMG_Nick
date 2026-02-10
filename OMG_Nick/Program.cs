using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMG_Nick
{
    internal static class Program
    {
        private static IModel model;
        private static IView view;
        private static IController controller;
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            model =new Model();
            view=new View();
            controller = new Controller();

            model.View = view;
            model.Controller = controller;

            view.Model = model;
            view.Controller = controller;

            controller.Model = model;
            controller.View = view;
                        
            Application.Run((View)view);
        }
    }
}
