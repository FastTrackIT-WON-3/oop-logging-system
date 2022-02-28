using OopLoggingSystem.Library;
using System;

namespace OopLoggingSystem.Terminal
{
    public static class ConsoleHelper
    {
        public static int ReadNumber(string label, int maxAttempts = 3, int defaultValue = 0)
        {
            if (label is not null)
            {
                Console.Write(label);
            }

            int attempts = 1;
            while (attempts <= maxAttempts)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int result))
                {
                    return result;
                }
                else
                {
                    attempts++;
                    Console.WriteLine($"Value '{input}' doesn't respresent a valid number. Please try again ...");
                    Console.Write(label);
                }
            }

            string message = $"Exceeded max attempts count {maxAttempts}, using {defaultValue} as default.";
            ApplicationLog.Write(new LogEntry(LogLevel.Warning, message));
            Console.WriteLine(message);
            return defaultValue;
        }
    }
}
