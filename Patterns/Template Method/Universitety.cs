using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Template_Method
{
    internal class Universitety : Education
    {
        public override void Enter()
        {
            Console.WriteLine("Give atestat to University");
        }

        public override void Study()
        {
            Console.WriteLine("yola veririk");
        }

        public override void PassExams()
        {
            Console.WriteLine("Passing a specialty exam");
        }

        public override void GetDocument()
        {
            Console.WriteLine("Take diplom");
        }
    }
}
