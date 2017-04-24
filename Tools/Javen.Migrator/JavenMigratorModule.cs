using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Javen.EntityFramework;

namespace Javen.Migrator
{
    [DependsOn(typeof(JavenDataModule))]
    public class JavenMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<JavenDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}