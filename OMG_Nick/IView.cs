using System.Reflection;

namespace OMG_Nick
{
    internal interface IView
    {
        IModel Model { set; }
        IController Controller { set; }
        void anzeigen(int ggt);
    }
}