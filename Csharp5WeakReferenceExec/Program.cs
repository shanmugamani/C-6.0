using System;
using System.Text;

namespace Csharp5WeakReferenceExec
{
    class Program
    {
        static void Main(string[] args)
        {
            WeakReference _Weak = null;
            try
            {
                StringBuilder builder = new StringBuilder();
                builder.Append("Hello World C# 6.0");

                Console.WriteLine(builder.ToString());
                builder = null;
                GC.Collect();

                Console.WriteLine(Convert.ToString(builder));
                builder = new StringBuilder();
                builder.Append("Hello World C# 6.0");

                Console.WriteLine("Introduce Weakreference");
                _Weak = new WeakReference(builder);

                if (_Weak.IsAlive)
                {
                    Console.WriteLine(builder.ToString());
                }
                builder = null;
                _Weak = new WeakReference(builder);
                GC.Collect();

                if (_Weak.IsAlive)
                {
                    Console.WriteLine(builder.ToString());
                }
                else
                {
                    Console.WriteLine($"Garbage collector moved {builder} object to bin");
                }


                builder = new StringBuilder();
                builder.Append("Hello World C# 6.0");
                _Weak = new WeakReference(builder);
                if (_Weak.IsAlive)
                {
                    Console.WriteLine(builder.ToString());
                }
                else
                {
                    Console.WriteLine($"Garbage collector moved {builder} object to bin");
                }

                Console.ReadKey();
            }
            catch (Exception err)
            {
                throw;
            }
        }
    }
}
