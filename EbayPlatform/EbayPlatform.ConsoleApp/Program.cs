using NLog;
using System;
using Topshelf;

namespace EbayPlatform.ConsoleApp
{
    class Program
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            HostFactory.Run(factory =>
            {
                factory.Service<ServiceRunner>();
                factory.SetServiceName("EbayPlatform.ConsoleAPP");
                factory.SetDescription("EbayPlatform 同步服务");
                factory.SetDisplayName("EbayPlatform.ConsoleAPP");
                factory.UseNLog();
                factory.OnException(ex =>
                {
                    logger.Error(ex, "启动服务发生异常");
                    Console.WriteLine($"创建服务发生异常{ex.Message},{ex.StackTrace}");
                });
            });
        }
    }
}
