using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStackLib
{
    public class CustomStackExtendedOP
    {
        public static void DisplayAllIntersNameAndID(ICustomStack<IInterns> stack)
        {
            while(stack.Count() >0)
            {
                Console.WriteLine(stack.Pop().NameId);
            }
        }
    }
}
