using Abp.AutoMapper;
using Abp.Dapper;
using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Adibi.Authorization;
using System.Collections.Generic;
using System.Reflection;

namespace Adibi
{
    [DependsOn(
        typeof(AdibiCoreModule),
        typeof(AbpAutoMapperModule),
        typeof(AbpEntityFrameworkCoreModule),
        typeof(AbpDapperModule))]
    public class AdibiApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AdibiAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AdibiApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            //DapperExtensions.SetMappingAssemblies(new List<Assembly> { typeof(AdibiApplicationModule).GetAssembly() });

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
