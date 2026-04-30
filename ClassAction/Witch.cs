using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassAction
{
    public class Witch : Character
    {
        private int Intelligence {get;set;}

        public override void Describe() => Console.WriteLine("nam");

       public Witch(string name, int health, int damage) : base(name , health, damage)
        {
            
        }
    }
}