using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMG_Nick
{
    internal class Controller : IController
    {
        private IModel model;
        private IView view;

        IModel IController.Model { set => model=value; }
        IView IController.View { set => view=value; }

        void IController.gGTBestimmen(int zahl1, int zahl2)
        {
            view.anzeigen(zahl2 + zahl1);
        }
    }
}
