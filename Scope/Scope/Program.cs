using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scope
{
   class Program
    {
       class Property
       {
           private string name;
           public string Name
           {
               get
               {
                   return this.name;
               }
               set
               {
                   this.name = value;
               }
           }
       }

       class Ronly
       {
           private string Myname = "Payam";


           public string ReadOnly
           {
               get { return Myname;}
           }
       }

       class WriteOnly
       {
           private string Myname;
           public string writemyname
           {
               set { Myname = value; }
           }

           public void Display()
           {
               Console.WriteLine("The name is {0}", this.Myname);
           }
       }

     class Normal
       {
           private string name
           {
               get;
               set;
           }
           private int age
           {
               get;
               set;
           }

           public void Writedate(string userName, int userAge)
           {
               this.name = userName;
               this.age = userAge;
           }

           public void Displaydata()
           {
               Console.WriteLine("the name of the person is {0}, and his age is {1}",name,age);
           }

        
       }
           


           static void Main(string[] args)
           {
               Ronly myread = new Ronly();
               Console.WriteLine(myread.ReadOnly);
               WriteOnly mywrite = new WriteOnly();
               mywrite.writemyname = "Pouria";
               mywrite.Display();

               Normal mynormal = new Normal();
               mynormal.Writedate(userName: "Payam", userAge: 31);
               mynormal.Displaydata();
               

               Console.ReadLine();
           }


        
    }
}
