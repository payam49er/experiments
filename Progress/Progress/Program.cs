using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Progress
{
    class Program
    {
        public static void MakeProgressBar(int min, int max, int initialvalue, int step)
        {
            //display the progress bar control
            ProgressBar bar = new ProgressBar();
           
            bar.Visible = true;

            //set minimum to 1 to to represent the first file being copied
            bar.Minimum = min;
            bar.Maximum = max;
            //initial value
            bar.Value = initialvalue;
            bar.Step = step;

            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Green;
            bar.PerformStep();
            

        }

        

        static void Main(string[] args)
        {
            MakeProgressBar(0, 100, 1, 1);

            Console.Read();
        }
    }
}
