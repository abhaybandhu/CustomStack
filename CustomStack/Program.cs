using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomStackLib;
namespace CustomStack
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CustomStackClass<Jedi> stack = new CustomStackClass<Jedi>();
            /*
            stack.Push("Jedi-x");
            stack.Pop();
            stack.Push("Jedi");
            stack.Push("SkillsLab");
            //stack.Push(100);

            while (stack.Count() > 0)
            {
                Console.WriteLine(stack.Pop());
            }

            */
            stack.Push(new Jedi("Jedi-x",1));
            stack.Push(new Jedi("Jedi",2));
            stack.Push(new Jedi("SkillsLab",3));

            CustomStackExtendedOP.DisplayAllIntersNameAndID(stack);
            Console.ReadLine();
        }
    }
}
