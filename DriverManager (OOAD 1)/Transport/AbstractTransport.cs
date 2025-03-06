using DriverManager__OOAD_1_.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverManager__OOAD_1_
{
    public abstract class AbstractTransport
    {
        private string name;
        private int capacity;
        public bool isBusy;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public abstract void Move(Location location);
    }
}
