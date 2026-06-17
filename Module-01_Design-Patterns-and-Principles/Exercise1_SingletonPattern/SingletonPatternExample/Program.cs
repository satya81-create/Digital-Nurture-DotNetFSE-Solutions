using System;

class Program
{
    static void Main(string[] args)
    {
        Logger firstLogger = Logger.GetLoggerInstance();
        Logger secondLogger = Logger.GetLoggerInstance();

        firstLogger.WriteLog("Application Started");
        secondLogger.WriteLog("User Logged In");

        Console.WriteLine(firstLogger.GetHashCode());
        Console.WriteLine(secondLogger.GetHashCode());

        Console.WriteLine(firstLogger == secondLogger);
    }
}
