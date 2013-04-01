using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Program
    {
       public struct Point
        {
            private int x, y;
            //constructor
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public int X { get; set; }
            public int Y { get; set; }
        }


        public class Form
        {
            public int A { get; set; }

            public Form(int A)
            {
                this.A = A;
            }
        }



        static void Main(string[] args)
        {
            Point testpoint = new Point(0,0);
            Form testform = new Form(10);

       

        }
    }
}
