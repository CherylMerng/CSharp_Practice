// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnumStructLinqFileHandling;
using static EnumStructLinqFileHandling._02_Struct;

namespace EnumStructLinqFileHandling {
    class Program { 

        static void Main(string[] args)
        {
            // _01_Enum._Enum();

            // _02_Struct
            /*MyStruct myStruct = new MyStruct(2, 3, 5);
            myStruct.PrintStatement();*/

            //_03_Linq._Linq();

            _04_FileHandling._FileHandling();
        }
    }

}