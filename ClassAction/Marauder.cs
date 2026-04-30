using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassAction
{
    public class Marauder : Character
    {
        private int Strength {get;set;}

        public override void Describe() => Console.WriteLine("nam");

       public Marauder(string name, int health, int damage) : base(name , health, damage)
        {
            
        }
    }
}