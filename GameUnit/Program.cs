using System;

namespace GameUnit
{
    public class Program
    {
        private static void Main(string[] args)
        {
            MilitaryUnit m = new MilitaryUnit(2, 10, 2);
            SettlerUnit s = new SettlerUnit();
            

            Console.WriteLine(m.Move());
            Console.WriteLine(s.Move());
            m.Attack(s);
            Console.WriteLine(s.Health);
            Console.WriteLine(m.Cost);
            Console.WriteLine(s.Cost);
            
        }
    }
}
