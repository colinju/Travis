using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Logic
{
    public class LoggerCsv : ILogger
    {
        public void write(string log)
        {
           using (StreamWriter file =
            new StreamWriter(@"C:\\Users\\julien\\source\\repos\\ConsoleApp1\\ClassLibrary1\\log.csv", true))
            {
                file.WriteLine(log + ";");
            }
        }
    }
}
