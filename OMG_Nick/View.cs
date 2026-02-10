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

        IModel IView.Model { set => model=value; }
        IController IView.Controller { set => controller=value; }

        void IView.anzeigen(int ggt)
        {
            textBoxGGT.Text = ggt.ToString();
        }

        private void buttonGGTBerechnen_Click(object sender, EventArgs e)
        {
            controller.gGTBestimmen(Convert.ToInt32(textBoxZahl1.Text), Convert.ToInt32(textBoxZahl2.Text));
        }
    }
}
