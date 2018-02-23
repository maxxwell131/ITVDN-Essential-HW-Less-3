using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Vehicle
    {
        readonly int xLocation;
        public int XLocation {get;} 

        readonly int yLocation;
        public int YLocation { get; }

        readonly uint price;
        public uint Price { get; }

        readonly uint speed;
        public uint Speed { get; }

        readonly uint year;
        public uint Year { get; }

        public Vehicle(int xLocation, int yLocation, uint price, uint speed, uint year)
        {
            this.xLocation = xLocation;
            this.yLocation = yLocation;
            this.price = price;
            this.speed = speed;
            this.year = year;
        }

        public Vehicle(uint price, uint speed, uint year)
            : this(0, 0, price, speed, year)
        {

        }
    }
}
