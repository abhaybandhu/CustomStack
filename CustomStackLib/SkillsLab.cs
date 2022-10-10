using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStackLib
{
    public class SkillsLab : IInterns
    {
        string name;
        int id;

        public string NameId => $"SkillsLab : {name}: {id}";
        public SkillsLab(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
    }
}
