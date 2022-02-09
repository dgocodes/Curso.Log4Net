// See https://aka.ms/new-console-template for more information

using log4net;
using log4net.Config;
using System.Reflection;

class Program
{
    private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod()?.DeclaringType);

    static void Main(string[] args)
    {
        var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
        XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));

        Console.WriteLine("Hello, World!");

        _log.Info("This is Info");
        _log.Error("This is Error");
        _log.Warn("This is Warn");
        _log.Fatal("This is Fatal");
        _log.Debug("This is Debug");
        Console.ReadKey();
    }
}