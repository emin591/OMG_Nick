namespace OMG_Nick
{
    internal interface IController
    {
        IModel model { set; }
        IView view { set; }
        void gGTBestimmen(int zahl1, int zahl2);
    }
}