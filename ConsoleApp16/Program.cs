using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Move();
            Train train = new Train();
            train.Move();
            train.MaxSpeed();
            car.MaxSpeed();
        }
    }
}
