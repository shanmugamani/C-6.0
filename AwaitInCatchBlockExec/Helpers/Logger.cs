using Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwaitInCatchBlockExec.Helpers
{
  public static  class Logger
    {
     

        public static Task WriteExceptionInaLogFile(Exception errorMsg)
        {
            try
            {
                string fileName = Constants.FileName;

                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.WriteLine(DateTime.Now);
                    writer.WriteLine(errorMsg.Message);
                    writer.WriteLine(errorMsg.InnerException);
                    writer.WriteLine(errorMsg.StackTrace);

                }
            }
            catch (Exception err)
            {
                throw;
            }
            return Task.FromResult<object>(null);
        }
    }
}
