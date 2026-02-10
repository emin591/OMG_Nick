using System.Reflection;

namespace OMG_Nick
{
    internal interface IView
    {
        IModel model { set; }
        IController controller { set; }
        void anzeigen(int ggt);
    }
}