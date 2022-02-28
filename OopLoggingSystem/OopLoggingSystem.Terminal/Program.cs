using OopLoggingSystem.Library;
using OopLoggingSystem.Library.Factories;


namespace OopLoggingSystem.Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            // initializare logger
            ApplicationLog.Initialize(new FileLoggerFactory(@"D:\Temp\ProblemWithLoggers\errorLog.txt"));

            int[] array = ArrayHelper.ReadFromConsole("Array");
            ArrayHelper.PrintToConsole("Array", array);
        }
    }
}
