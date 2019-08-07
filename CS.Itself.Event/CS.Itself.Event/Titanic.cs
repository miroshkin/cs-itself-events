using System;
namespace CS.Itself.Event
{
    public delegate void SomethingHappened();

    public class Titanic
    {


        public event SomethingHappened SomethingHappened;


        public void ServeRichPassengers()
        {
            Console.WriteLine("The best dishes for the best people!");
        }

        public void PlayMusic()
        {
            Console.WriteLine("Play the jazz!");
        }

        public void OnSomethingHappened()
        {
            Console.WriteLine("SOS!");
            SomethingHappened();
        }
    }
}
