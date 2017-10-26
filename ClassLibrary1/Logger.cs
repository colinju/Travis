using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Logic
{
    public class Logger : ILogger
    {
        public void write(string log)
        {
            Console.WriteLine(log);
        }
    }
}
