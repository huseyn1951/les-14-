using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp16
{
    class Train :Vechile,IMaxSpeed1
    {
        public void MaxSpeed()
        {
            Console.WriteLine("train's max speed is 500 km/h"); ;
        }

        public override void Move()
        {
            Console.WriteLine("train  make a sound like chux chux chux"); ;
        }
        
    }
}
