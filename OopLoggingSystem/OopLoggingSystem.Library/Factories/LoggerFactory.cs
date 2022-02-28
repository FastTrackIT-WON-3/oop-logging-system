using OopLoggingSystem.Library.Loggers;

namespace OopLoggingSystem.Library.Factories
{
    public abstract class LoggerFactory
    {
        internal abstract Logger Create();
    }
}
