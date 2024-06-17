using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysticPartyTracker.Models
{
    public class Character
    {
        public Character(string name, int lvl, string classe, string raca)
        {
            this.name = name;
            this.lvl = lvl;
            this.classe = classe;
            this.raca = raca;
        }

        public string name { get; set; }
        public int lvl { get; set; }
        public string classe { get; set; }
        public string raca { get; set; }
    }
}
