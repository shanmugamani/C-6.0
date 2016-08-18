#region Namespace(s)
using System;
using System.Runtime.CompilerServices;
#endregion

namespace CSharp5CallerInfoExec
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowCallerInfo();
            Console.ReadKey();
        }

        public static void ShowCallerInfo([CallerMemberName] string callerName = null, 
                                          [CallerFilePath] string callerFilePath = null, 
                                          [CallerLineNumber] int callerLine = -1)
        {
            Console.WriteLine("Caller Name: {0}", callerName);
            Console.WriteLine("Caller FilePath: {0}", callerFilePath);
            Console.WriteLine("Caller Line number: {0}", callerLine);
        }

    }


}
