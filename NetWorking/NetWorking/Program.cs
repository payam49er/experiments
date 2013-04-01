using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace NetWorking
{
    class Program
    {
        class WorkStation
        {
            public string GetIp(string ip)
            {
                IPAddress ipaddress = Dns.GetHostEntry(ip).AddressList[0];
                return ipaddress.ToString();
            }
           
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please insert a website address to get its IP address:");
            string ip = Console.ReadLine();

            WorkStation myworkstation = new WorkStation();
            Console.WriteLine("The IP Address for {0} is {1}", ip, myworkstation.GetIp(ip));

            Console.Read();
        }
    }
}
