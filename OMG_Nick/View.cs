using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMG_Nick
{
    public partial class View : Form,IView
    {
        private IModel model;
        private IController controller;

        public View()
        {
            InitializeComponent();
        }

        IModel IView.model { set => throw new NotImplementedException(); }
        IController IView.controller { set => throw new NotImplementedException(); }

        void IView.anzeigen(int ggt)
        {
            throw new NotImplementedException();
        }

        private void buttonGGTBerechnen_Click(object sender, EventArgs e)
        {

        }
    }
}
