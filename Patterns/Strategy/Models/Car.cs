using Patterns.Strategy.Interfaces;

namespace Patterns.Strategy.Models
{
    internal class Car : ITransport
    {
        public void UseTransport()
        {
            Console.WriteLine("you bought a car");
        }
    }
}
