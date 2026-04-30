using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassAction
{
    public class Marauder : Character
    {
        private int Strength {get;set;}

        public override void Describe() => Console.WriteLine($"{Name} [Marauder] (Health: {Health}, Damage: {Damage}, Strength: {Strength})");

       public Marauder(string name, int health, int damage, int strength) : base(name , health, damage)
        {
            Strength = strength;
        }
    }
}