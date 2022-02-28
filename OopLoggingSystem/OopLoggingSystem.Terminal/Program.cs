using OopLoggingSystem.Library;
using OopLoggingSystem.Library.Factories;
using OopLoggingSystem.Library.Loggers;
using System;

namespace OopLoggingSystem.Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            // initializare logger
            ApplicationLog.Initialize(new ConsoleLoggerFactory());

            int[] array = ArrayHelper.ReadFromConsole("Array");
            ArrayHelper.PrintToConsole("Array", array);
        }
    }
}
