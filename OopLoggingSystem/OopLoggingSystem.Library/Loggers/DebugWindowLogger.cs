using System;
using System.Diagnostics;

namespace OopLoggingSystem.Library.Loggers
{
    internal class DebugWindowLogger : Logger
    {
        public override void Write(LogEntry entry)
        {
            if (Debugger.IsAttached)
            {
                Debug.WriteLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}] [{entry.LogLevel}] {entry.Message}");
            }
        }
    }
}
