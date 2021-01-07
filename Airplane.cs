using ISP.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISP
{
    public class Airplane : IAirplane
    {
        

        public void Fly()
        {
            //actions to fly a plane
            Console.WriteLine("Flying a plane");
        }
    }
}
