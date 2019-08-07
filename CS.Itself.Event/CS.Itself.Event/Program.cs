using System;

namespace CS.Itself.Event
{
    class Program
    {
        static void Main(string[] args)
        {
            Titanic titanic = new Titanic();
            Carpathia carpathia = new Carpathia();

            titanic.SomethingHappened += carpathia.SavePassengers;

            titanic.PlayMusic();
            titanic.ServeRichPassengers();

            titanic.OnSomethingHappened();

        }
    }
}
