using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStackLib
{
    public interface ICustomStack<T>
    {
        int Count();
        void Push(T new_item);
        T Pop();
    }
}
