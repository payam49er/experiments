///<summary>
///plan for Cantina, read the input file and use the class type Cantina to fill the values needed
///Then read the supposed output file. Properly fill in values that are needed from the class Cantina and save the file in the 
///output folder. 
///</summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace CantinaTask
{
    class Program
    {
        public class Cantina
        {
            public string[] name { get; set; }
            public string[] product{get; set;}
            public string[] email { get; set; }
            public string date { get; set; }

        }



        static void Main(string[] args)
        {
           
            Cantina cantina = new Cantina();
            try
            {
                using (StreamReader sr = new StreamReader(@"E:\Csharp\template-system\input\1"))
                {
                  
                    String line1 = sr.ReadLine();
                    cantina.name = line1.Split('=');
                  
                    String line2 = sr.ReadLine();
                    cantina.product = line2.Split('=');
                    
                    String line3 = sr.ReadLine();
                    cantina.email = line3.Split('=');

                    String line4 = sr.ReadLine();
                    string[] temp = line4.Split('=');
                    long tempdate = Int64.Parse(temp[1]);
                    long sec = tempdate / 1000;
                    DateTime dtime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
                    dtime = dtime.AddSeconds(sec).ToUniversalTime();
                    string mydate = String.Format((dtime.DayOfWeek.ToString() + "," + dtime.Month.ToString()+"," + dtime.Day.ToString() + "," + dtime.Year.ToString()));
                    cantina.date = mydate;
                    //DateTime ddtime = new DateTime(dtime.Year, dtime.Day, dtime.Month);
                    
                    //cantina.date =  DateTime.ParseExact(dtime.ToString(),"D", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
              

            //now we have to go and read the template to place the values

            try
            {
                using (StreamReader mytemplate = new StreamReader(@"E:\Csharp\template-system\template"))
                {
                    string data = mytemplate.ReadToEnd();
                    StringBuilder lines = new StringBuilder(data);
                   
                   lines.Replace("{name}", cantina.name[1]);
                   lines.Replace("{product}", cantina.product[1]);
                   lines.Replace("{email|filter:lowercase}", cantina.email[1].ToLower());
                   lines.Replace("{date|format:date}", cantina.date);

                    StreamWriter file = new StreamWriter(@"E:\Csharp\template-system\output\out1.txt");
                    file.WriteLine(lines);

                    file.Close();


                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
                
            
            
                


            Console.Read();
        }
    }
}
