using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnit
{
    public class SettlerUnit : Unit 
    {
        public SettlerUnit() : base(1, 3)
        {
            
        }
        public override float Cost
        {
            get
            {
                return 5;
            }
        }
       
    }   
}