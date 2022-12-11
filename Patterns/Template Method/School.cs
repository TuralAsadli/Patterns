using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Template_Method
{
    internal class School : Education
    {
        public override void Enter()
        {
            Console.WriteLine("You Entered to the school");
        }

        public override void GetDocument()
        {
            Console.WriteLine("Get atestat from school");
        }

        public override void Study()
        {
            Console.WriteLine("Study in school");
        }
    }
}
