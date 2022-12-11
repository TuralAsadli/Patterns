using Patterns.Momento.Models;
using Patterns.Strategy.Models;
using Patterns.Template_Method;

namespace Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Strategy
            Passenger passenger = new Passenger("Tural");
            passenger.ChooseTransport(new Car());
            passenger.UseTransport();
            #endregion

            #region Momento
            Accaunt originator = new Accaunt("person1", "12345");
            originator.ChangeName("person2");
            originator.ChangePassword("6789");
            originator.ShowInfo();
            originator.SetOldValue();
            originator.ShowInfo();
            #endregion

            #region Template Method
            School school = new School();
            Universitety universitety = new Universitety();

            school.Learn();
            universitety.Learn();
            #endregion
        }
    }
}