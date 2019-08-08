using System;
using System.Xml.Xsl;

namespace CS.Itself.Event
{
    public delegate void SomethingHappened();

    public delegate void SendMessage(object sender, MessageArgs args);

    public class Titanic
    {


        public event SomethingHappened SomethingHappened;
        public event SendMessage SendMessage;

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
            SomethingHappened?.Invoke();
            SendMessage?.Invoke(this.GetType(), new MessageArgs() { ShipName = "Titanic", Message = "SOS" });
        }
    }
}
