using Patterns.Strategy.Interfaces;

namespace Patterns.Strategy.Models
{
    internal class Train : ITransport
    {
        public void UseTransport()
        {
            Console.WriteLine("You buy a tiket for train");
        }
    }
}
