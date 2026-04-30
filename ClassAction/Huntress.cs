using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassAction
{
    public class Huntress : Character
    {
        private int Dexterity {get;set;}

        public override void Describe() => Console.WriteLine($"{Name} [Huntress] (Health: {Health}, Damage: {Damage}, Dexterity: {Dexterity})");

       public Huntress(string name, int health, int damage, int dexterity) : base(name , health, damage)
        {
            Dexterity = dexterity;
        }

         public override void Attack()
        {
            Console.Write("Attack: Fangs of Frost!");
        }
    }
}