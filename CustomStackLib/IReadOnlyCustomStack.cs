using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStackLib
{
    public interface IReadOnlyCustomStack<T>
    {
        void Push (T new_item);
        int Count();
    }
}
