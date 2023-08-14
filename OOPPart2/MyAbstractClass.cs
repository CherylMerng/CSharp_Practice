﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPart2
{
    // 4 - Abstract Class
    abstract class MyAbstractClass
    {
        private string message = "Hello C#";

        public void PrintMessage()
        {
            Console.WriteLine(message);
        }

        public abstract void PrintMessageAbstract();

    }
}
