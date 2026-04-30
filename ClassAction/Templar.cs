using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassAction
{
    public class Templar : Character
    {
       private int Strength {get;set;}
       private int Intelligence {get;set;}

       public override void Describe() => Console.WriteLine($"{Name} [Templar] (Health: {Health}, Damage: {Damage}, Strength: {Strength}, Intelligence {Intelligence})");

       public Templar(string name, int health, int damage, int strength, int intelligence) : base(name , health, damage)
        {
            Strength = strength;
            Intelligence = intelligence;
        }

         public override void Attack()
        {
            Console.Write("Attack: Divine Blast!");
        }
    }
}