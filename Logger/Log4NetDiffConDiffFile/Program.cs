using System;
using log4net;
using log4net.Config;

namespace log4net
{
    class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));

        static void Main()
        {
            XmlConfigurator.Configure(new FileInfo("log4net.config"));

            log.Info("Program Started.");
            log.Debug("Performing a calculation.");

            int x = 5;
            int y = 10;

            int result = x * y;

            // Log the result of the operation
            log.Debug($"The result of the calculation is: {result}");

            // Log a message when the program ends
            log.Info("Program finished.");
            log.Error("OH NO!!");
        }
    }
}