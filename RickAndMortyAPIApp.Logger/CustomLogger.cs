using Serilog;

namespace RickAndMortyAPIApp.Logger;

public class CustomLogger
{
    public CustomLogger()
    {
        Log.Logger = new LoggerConfiguration().MinimumLevel.Information().WriteTo.Console().WriteTo
            .File("logs/log.txt", rollingInterval: RollingInterval.Day).CreateLogger();
    }

    public void LogInformation(string message,object?[]? result)
    {
        Log.Information(message,result);
        
    }
}