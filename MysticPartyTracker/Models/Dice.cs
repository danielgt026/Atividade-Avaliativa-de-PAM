using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysticPartyTracker.Models
{
    public class Dice
    {
        public int Lados { get; set; }
        public Dice(int lados)
        {
            Lados = lados;
        }  

        public int Roll() 
        { 
            return new Random().Next(1, Lados) + 1; 
        }
    }
}
