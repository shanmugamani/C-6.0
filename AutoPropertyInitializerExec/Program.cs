using AutoPropertyInitializerExec.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPropertyInitializerExec
{
    class Program
    {
        static void Main(string[] args)
        {
            Player objPlayer = new Player();
            Console.WriteLine("Before Property Change");
            Console.WriteLine(objPlayer.FirstName);
            Console.WriteLine();
            objPlayer.FirstName = "Mark";
            Console.WriteLine("After Property Change");
            Console.WriteLine(objPlayer.FirstName);
            Console.WriteLine();
            Console.WriteLine("ReadOnly Property");
            Console.WriteLine(objPlayer.LastName);
            Console.ReadKey();
        }
    }
}
