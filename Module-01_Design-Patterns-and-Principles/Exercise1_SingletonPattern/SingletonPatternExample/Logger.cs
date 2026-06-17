public sealed class Logger
{
    private static Logger? loggerInstance;

    private Logger()
    {
        Console.WriteLine("Logger Instance Created");
    }

    public static Logger GetLoggerInstance()
    {
        if (loggerInstance == null)
        {
            loggerInstance = new Logger();
        }

        return loggerInstance;
    }

    public void WriteLog(string message)
    {
        Console.WriteLine("[LOG] " + message);
    }
}


