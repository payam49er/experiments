using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an action delegate

            Task task1 = new Task(new Action(printMessage));
            //use an annonymous delegate
            Task task2 = new Task ( delegate {printMessage()});



        }
    }
}
