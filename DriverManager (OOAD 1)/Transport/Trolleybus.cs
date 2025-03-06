using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverManager__OOAD_1_.Transport
{
    class Trolleybus : AbstractTransport
    {
        public Trolleybus(string name, int size)
        {
            Name = name;
            Capacity = size;
        }
        public override void Move(Location location)
        {
            //Логика метода Move
        }
    }
}
