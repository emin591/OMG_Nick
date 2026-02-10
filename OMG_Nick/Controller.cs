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

        IModel IController.model { set => throw new NotImplementedException(); }
        IView IController.view { set => throw new NotImplementedException(); }

        void IController.gGTBestimmen(int zahl1, int zahl2)
        {
            throw new NotImplementedException();
        }
    }
}
