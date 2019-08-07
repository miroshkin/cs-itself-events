using System;
namespace CS.Itself.Event
{
    public class Titanic
    {

        public event  SOS;

        public void SendSOS()
        {

        }

        public void ServeRichPassengers()
        {
            Console.WriteLine("The best dishes for the best people!");
        }

        public void PlayMusic()
        {
            Console.WriteLine("Play the jazz!");
        }
    }
}
