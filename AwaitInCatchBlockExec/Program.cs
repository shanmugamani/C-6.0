using AwaitInCatchBlockExec.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwaitInCatchBlockExec
{
    class Program
    {
        static  void Main(string[] args)
        {
            try
            {
                Task.Factory.StartNew(() => Div());
                Console.ReadKey();
            }
            catch (Exception err)
            {
                throw;
            }


        }

        private static async void  Div()
        {
            int result = 0;
            try
            {
                int num1 = 10;
                int num2 = 0;

                result = num1 / num2;
               // Console.WriteLine($"Calculated Value is {result}");
            }
            catch (Exception err)
            {
                await Logger.WriteExceptionInaLogFile(err);                
            }
        }
    }
}
