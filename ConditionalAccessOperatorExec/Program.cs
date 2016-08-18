using ConditionalAccessOperatorExec.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalAccessOperatorExec
{
    class Program
    {
        static void Main(string[] args)
        {
            Order objOrder = null;

            Customer objCustomer = new Customer();
            objCustomer.CustomerID = 1;
            objCustomer.Name = "Mark";
            objCustomer.OrderItem = objOrder;

            Console.WriteLine("Customre Name:{0}", objCustomer.Name);
            Console.WriteLine("Bought:{0}", objCustomer.OrderItem?.ItemName);
            Console.ReadKey();
            
        }
    }
}
