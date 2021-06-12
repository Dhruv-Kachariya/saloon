using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using saloon.Authorization;

namespace saloon
{
    [DependsOn(
        typeof(saloonCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class saloonApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<saloonAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(saloonApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
