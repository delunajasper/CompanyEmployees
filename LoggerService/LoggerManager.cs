using CompanyEmployees.Contracts;
using NLog;

namespace CompanyEmployees.LoggerService;

public class LoggerManager : IloggerManager
{
    private static ILogger logger = LogManager.GetCurrentClassLogger();

    public LoggerManager()
    {
    }

    public void LogInfo(string message) => logger.Info(message);
    public void LogWarn(string message) => logger.Warn(message);
    public void LogDebug(string message) => logger.Debug(message);
    public void LogError(string message) => logger.Error(message);

}