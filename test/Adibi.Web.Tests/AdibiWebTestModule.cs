using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Adibi.EntityFrameworkCore;
using Adibi.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Adibi.Web.Tests
{
    [DependsOn(
        typeof(AdibiWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class AdibiWebTestModule : AbpModule
    {
        public AdibiWebTestModule(AdibiEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AdibiWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(AdibiWebMvcModule).Assembly);
        }
    }
}