﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTon
{
    class Program
    {
        public sealed class Singleton
        {
            private static Singleton instance = null;
            private static readonly object padlock = new object();

            //empty constructor
            Singleton()
            {
            }

            public static Singleton Instance
            {
                get
                {
                    lock (padlock)
                    {

                        if (instance == null)
                            instance = new Singleton();
                        return instance;
                    }
                }
            }

        }


        static void Main(string[] args)
        {
        }
    }
}
