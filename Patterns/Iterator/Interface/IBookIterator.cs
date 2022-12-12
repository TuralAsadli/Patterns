using Patterns.Iterator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Iterator.Interface
{
    interface IBookIterator
    {
        bool HasNext();
        Book Next();
    }
}
