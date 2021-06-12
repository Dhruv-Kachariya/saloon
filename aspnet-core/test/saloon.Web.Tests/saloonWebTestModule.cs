using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using saloon.EntityFrameworkCore;
using saloon.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace saloon.Web.Tests
{
    [DependsOn(
        typeof(saloonWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class saloonWebTestModule : AbpModule
    {
        public saloonWebTestModule(saloonEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(saloonWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(saloonWebMvcModule).Assembly);
        }
    }
}