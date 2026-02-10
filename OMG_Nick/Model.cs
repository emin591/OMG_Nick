using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMG_Nick
{
    internal class Model : IModel
    {
        private IView view;
        private IController controller;
        IView IModel.View { set => view=value; }
        IController IModel.Controller { set => controller=value; }
    }
}
