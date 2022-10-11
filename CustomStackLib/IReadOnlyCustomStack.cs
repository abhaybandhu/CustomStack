using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStackLib
{
    public interface IReadOnlyCustomStack<out T>
    {
        T Pop ();
        int Count();
    }
}
