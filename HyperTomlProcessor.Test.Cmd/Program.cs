﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperTomlProcessor.Test.Cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TomlConvert.SerializeObject(TestObject.Create()));
            Console.ReadKey();
        }
    }
}
