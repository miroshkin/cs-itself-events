using System;
namespace CS.Itself.Event
{
    public class Carpathia
    {
        public void SavePassengers()
        {
            Console.WriteLine("Something went wrong. It is time to help people");
        }

        public void GetMessage(object sender, MessageArgs args)
        {
            Console.WriteLine($"Ship {args.ShipName} have sent a message: {args.Message}. Source class: {sender}");
        }
    }
}
