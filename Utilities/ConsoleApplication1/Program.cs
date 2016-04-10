using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Utilities;

namespace Log4NetTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Trace.Write("Trece Message", "Info Trace");
            for (int i = 0; i < 2500; i++)
            {
                Logger.Log("Error Message", Level.ERROR);
                Logger.Log("Info Message", Level.INFO);
                Logger.Log("WARN Message", Level.WARN);
                Logger.Log("Debug Message", Level.DEBUG);
                Logger.Log("Fatal message", Level.FATAL);
            }
            Logger.Log("========================FINISH==========================", Level.INFO);
            Console.Read();
        }
    }
}
