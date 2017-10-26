using Logic;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = "";
            do
            {
                var converter = new MyConverter();
                var loggerConsole = new Logger();
                var loggerTxt = new LoggerTxt();
                var loggerCsv = new LoggerCsv();
                Console.WriteLine("Entrez un chiffre romain ou q pour quitter");

                x = Console.ReadLine();
                if (x != "q")
                {
                    try
                    {
                        Console.WriteLine(converter.Convert(x));
                        loggerConsole.write("Convertion de : " + x);
                        loggerTxt.write("Convertion de : " + x);
                        loggerCsv.write("Convertion de : " + x);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        loggerConsole.write("Exception : " + e.Message);
                        loggerTxt.write("Exception : " + e.Message);
                        loggerCsv.write("Exception : " + e.Message);
                    }
                }
            } while (x != "q");
            
        }
    }
}
