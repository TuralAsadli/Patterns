using Patterns.Strategy.Interfaces;

namespace Patterns.Strategy.Models
{
    internal class Passenger
    {
        public string Name { get; set; }

        public ITransport UsingTransport { get; set; }
        public Passenger(string name)
        {
            Name = name.Trim();

        }

        public void ChooseTransport(ITransport transport)
        {
            UsingTransport = transport;
        }

        public void UseTransport()
        {
            if (UsingTransport == null)
            {
                Console.WriteLine("Not found Transport");
                return;
            }

            UsingTransport.UseTransport();
        }
    }
}
