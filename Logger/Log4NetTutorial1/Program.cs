using log4net;
using log4net.Config;

namespace LoggingExample
{
    class Program
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(Program));
        
        static void Main()
        {
            XmlConfigurator.Configure(new FileInfo("log4net.config"));
            logger.Debug("This is a debug messsage");
            logger.Info("This is an example message");
            logger.Warn("This is a warning message");
            logger.Error("This is an error message");
            logger.Fatal("This is a fatal message");
            GameRunner.Message("Game running.");
        }
    }

    class GameRunner
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(GameRunner));
        public static void Message(string args)
        {
            logger.Info(args);
        }
    }
}
