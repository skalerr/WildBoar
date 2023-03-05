using Autofac;
using Autofac.Core;
using Autofac.Core.Registration;
using DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Module = Autofac.Module;

namespace DAL
{
    public class DALModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            Console.WriteLine("Начало загрузки модуля DAL");
            builder.RegisterModule<EFModule>();
            Console.WriteLine("Конец загрузки модуля DAL");
        }
    }
}
