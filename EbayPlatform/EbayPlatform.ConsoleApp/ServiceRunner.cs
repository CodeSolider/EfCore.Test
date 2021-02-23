using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using Topshelf;
using NLog;
using Microsoft.EntityFrameworkCore;
using EbayPlatform.DataBase;
using EbayPlatform.Utility.Extensions;
using EbayPlatform.Infrastructure;
using EbayPlatform.DataBase.Models;

namespace EbayPlatform.ConsoleApp
{
    public class ServiceRunner : ServiceControl, ServiceSuspend
    {
        /// <summary>
        /// 服务容器
        /// </summary>
        private readonly IServiceCollection services;

        /// <summary>
        /// 配置器
        /// </summary>
        private IConfiguration Configuration { get; }

        /// <summary>
        /// 日志
        /// </summary>
        private readonly Logger logger = LogManager.GetCurrentClassLogger();

        public ServiceRunner()
        {
            Configuration = new ConfigurationBuilder()
                            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                            .AddJsonFile("appsettings.json")
                            .Build();

            services = new ServiceCollection();
            InitConfiguration();

            using var serviceScope = services.BuildServiceProvider().CreateScope();
            var unitOfWork = serviceScope.ServiceProvider.GetRequiredService<IUnitOfWork>();
            var repository = unitOfWork.GetRepository<SyncJobConfig>();
            var pagedList = repository.GetPagedList();


        }

        /// <summary>
        /// 开启
        /// </summary>
        /// <param name="hostControl"></param>
        /// <returns></returns>
        public bool Start(HostControl hostControl)
        {
            logger.Info("服务已启动");
            return true;
        }

        /// <summary>
        /// 暂停
        /// </summary>
        /// <param name="hostControl"></param>
        /// <returns></returns>
        public bool Pause(HostControl hostControl)
        {
            logger.Info("服务已暂停");
            return true;
        }

        /// <summary>
        /// 继续
        /// </summary>
        /// <param name="hostControl"></param>
        /// <returns></returns>
        public bool Continue(HostControl hostControl)
        {
            logger.Info("服务已继续");
            return true;
        }

        /// <summary>
        /// 停止
        /// </summary>
        /// <param name="hostControl"></param>
        /// <returns></returns>
        public bool Stop(HostControl hostControl)
        {
            logger.Info("服务已停止");
            //scheduler.Shutdown(true);
            return true;
        }

        #region 私有方法
        /// <summary>
        /// 初始化配置
        /// </summary>
        void InitConfiguration()
        {
            services.AddDbContext<EbayPlatformContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("EbayPlatformDatabase"));
            }).AddUnitOfWork<EbayPlatformContext>();
        }
        #endregion

    }
}