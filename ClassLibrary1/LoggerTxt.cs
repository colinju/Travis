using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Logic
{
    public class LoggerTxt : ILogger
    {
        public void write(string log)
        {
            using (StreamWriter file =
             new StreamWriter(@"C:\\Users\\julien\\source\\repos\\ConsoleApp1\\ClassLibrary1\\log.txt", true))
            {
                file.WriteLine(log);
            }
        }
    }
}
