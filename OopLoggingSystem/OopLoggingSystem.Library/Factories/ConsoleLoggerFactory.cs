using OopLoggingSystem.Library.Loggers;

namespace OopLoggingSystem.Library.Factories
{
    public class ConsoleLoggerFactory : LoggerFactory
    {
        internal override Logger Create()
        {
            return new ConsoleLogger();
        }
    }
}
