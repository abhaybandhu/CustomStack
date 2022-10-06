using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStackLib
{
    public class Jedi : INamedEntity
    {
        string name;
        int id;

        public string NameId => $"Jedi : {name}: {id}";
        public Jedi(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
    }
}
