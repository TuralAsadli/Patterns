using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Template_Method
{
    internal abstract class Education : Learning
    {
        public override void Learn()
        {
            Enter();
            Study();
            PassExams();
            GetDocument();
        }
        public abstract void Enter();
        public abstract void Study();
        public virtual void PassExams()
        {
            Console.WriteLine("Pass last exams");
        }
        public abstract void GetDocument();
    }
}
