using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStackLib
{
    public class CustomStackExtendedOP
    {
        public static void DisplayAllIntersNameAndID<T>(CustomStackClass<T> stack) where T : INamedEntity
        {
            while(stack.Count() >0)
            {
                Console.WriteLine(stack.Pop().NameId);
            }
        }
    }
}
