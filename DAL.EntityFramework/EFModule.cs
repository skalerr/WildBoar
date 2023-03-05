using DAL.EntityFramework.DB;
using DAL.EntityFramework.Repository.EfRepository;
using Autofac;
using Module = Autofac.Module;

namespace DAL.EntityFramework;

public class EFModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {

        builder.RegisterType<AppEfContext>().AsSelf().InstancePerLifetimeScope();
        builder.RegisterGeneric(typeof(EfRepository<>)).As(typeof(EfRepository<>)).InstancePerLifetimeScope();
        Console.WriteLine("Загрузка EFCore");
    }
}