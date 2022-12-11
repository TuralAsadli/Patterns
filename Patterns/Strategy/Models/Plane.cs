using Patterns.Strategy.Interfaces;

namespace Patterns.Strategy.Models
{
    internal class Plane : ITransport
    {
        public void UseTransport()
        {
            Console.WriteLine("You buy a tiket for Plane");
        }
    }
}
