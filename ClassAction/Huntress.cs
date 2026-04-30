using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassAction
{
    public class Huntress : Character
    {
        private int Dexterity {get;set;}

        public override void Describe() => Console.WriteLine("nam");

       public Huntress(string name, int health, int damage) : base(name , health, damage)
        {
            
        }

    }
}