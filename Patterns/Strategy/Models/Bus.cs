using Patterns.Strategy.Interfaces;

namespace Patterns.Strategy.Models
{
    internal class Bus : ITransport
    {
        public void UseTransport()
        {
            Console.WriteLine("You by a ticket for bus");
        }
    }
}
