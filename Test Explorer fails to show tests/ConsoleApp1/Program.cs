﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    using System.Reflection;
    using System.Runtime.InteropServices;

    class Program
    {
        static void Main(string[] args)
        {
            Assembly.Load("System.Runtime, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
            Console.WriteLine(System.Runtime.GCSettings.IsServerGC);
        }
    }
}
