using ISP.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISP
{
    public class Car : ICar
    {
        public void Drive()
        {
            //actions to drive a car
            Console.WriteLine("Driving a car");
        }

        
    }
}
