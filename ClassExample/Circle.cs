using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    internal class Circle
    {

        public int Radius { get; set; }

        /// <summary>
        /// Creates a new Circle and sets the radius property, the 
        /// </summary>
        /// <param name="radius"></param>
        /// <exception cref="ArgumentException"></exception>
        public Circle(int radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Must have a positive radius");
            }
            else
            {
                Radius = radius;
            }
        }
    }
}
