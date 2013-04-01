///recursive solution to the tower of Hanoi puzzle. A calssic computer sience puzzle! 
///Coded by Payam Shoghi
///Note: The code is quite simple, but the the logic behind it is quite profound. It is very intuitive. 
///Look at the code for a while and try to appriciate the mechanism. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi
{
    class Program
    {
        // this method gets the number of disks that need to be moved and the rods in order A, B, C 
        public static void MoveDisks(int numberofdisks, string A, string B, string C)
        {
            
            //defining the base case
            if (numberofdisks == 1)
            {
                Console.WriteLine("Move disk 1 from {0} to {1} and finally to {2}", A, B, C);
            }
            else
            {
                MoveDisks(numberofdisks - 1, A, C, B);
                Console.WriteLine("Move disk {0} from {1} to {2} ", numberofdisks,A, C);  // moving to the middle rod
                MoveDisks(numberofdisks - 1, B, A, C); //moving from the middle to destination rod
                
            }

        }

        static void Main(string[] args)
        {

            Console.WriteLine("Please insert the number of disks that you want to move:");
            int numberofdisks = Convert.ToInt32(Console.ReadLine());
            MoveDisks(numberofdisks,"A","B","C");
            Console.ReadLine();
        }
    }
}
