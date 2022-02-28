using OopLoggingSystem.Library.Loggers;

namespace OopLoggingSystem.Library.Factories
{
    public class DebugWindowLoggerFactory : LoggerFactory
    {
        internal override Logger Create()
        {
            return new DebugWindowLogger();
        }
    }
}
