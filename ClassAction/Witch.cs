using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassAction
{
    public class Witch : Character
    {
        private int Intelligence {get;set;}

        public override void Describe() => Console.WriteLine($"{Name} [Witch] (Health: {Health}, Damage: {Damage}, Intelligence: {Intelligence})");

       public Witch(string name, int health, int damage, int intelligence) : base(name , health, damage)
        {
            Intelligence = intelligence;
        }
    }
}