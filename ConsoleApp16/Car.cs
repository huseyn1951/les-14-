using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp16
{
    class Car : Vechile,IMaxSpeed1
    {
        public void MaxSpeed()
        {
            Console.WriteLine("car's max speed is 300 km/h");
        }

        public override void Move()
        {
            Console.WriteLine("car have 4 wheels and make a sound like vjjjjjjjj"); ;
        }
    }
}
