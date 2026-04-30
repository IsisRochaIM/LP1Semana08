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

       public override void Describe() => Console.WriteLine("nam");

       public Templar(string name, int health, int damage) : base(name , health, damage)
        {
            
        }
    }
}