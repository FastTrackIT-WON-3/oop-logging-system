namespace OopLoggingSystem.Library
{
    public class LogEntry
    {
        public LogEntry(LogLevel logLevel, string message)
        {
            LogLevel = logLevel;
            Message = message;
        }

        public LogLevel LogLevel { get; }

        public string Message { get; }
    }
}
