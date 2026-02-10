namespace OMG_Nick
{
    internal interface IController
    {
        IModel Model { set; }
        IView View { set; }
        void gGTBestimmen(int zahl1, int zahl2);
    }
}