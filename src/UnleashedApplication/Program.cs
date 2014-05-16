using System;
using System.Reflection;
using Autofac;
using OpenDDD;
using OpenDDD.UnitOfWorkContext;
using UnleashedDDD;
using UnleashedDDD.Accounting.Port;
using UnleashedDDD.Infrastructure.Azure;
using UnleashedDDD.Inventory.Application.Commands;
using UnleashedDDD.Main;
using UnleashedDDD.Organizations.Application.Commands;
using UnleashedDDD.Sales.Application.Commands;

namespace UnleashedApplication
{
    class Program
    {
        private static UnleashedCore Core;

        static void Main(string[] args)
        {
            var container = InitializeContainer(typeof(Queue).Assembly);

            Core = container.Resolve<UnleashedCore>();

            Playground();
        }

        static void Playground()
        {
            //Core.Sales.CompleteSalesOrder(new CompleteSalesOrderCommand(Guid.NewGuid()));

            for (var i = 0; i < 50; i++)
                Core.Sales.CreateNewSalesOrder(new NewSalesOrderCommand(Guid.NewGuid(), Guid.NewGuid()));

                //Core.Organizations.RegisterNewUser(new NewUserCommand("zdenek"+ i.ToString()+"@sejcek.cz", "Zdenek", "Sejcek"));

            var warehouse = Core.Inventory.CreateNewWarehouse(new NewWarehouseCommand("warehouse name"));

            var newOrganization = Core.Organizations.RegisterNewOrganization(new NewOrganizationCommand(Guid.NewGuid(), "My super trooper Org"));

            var so = Core.Sales.CreateNewSalesOrder(new NewSalesOrderCommand(Guid.NewGuid(), Guid.NewGuid()));

            using (var uow = new UnitOfWork())
            {
                var model = Core.Inventory.CreateNewWarehouse(new NewWarehouseCommand("Warehouse"));

                uow.Commit();
            }

            Console.ReadLine();            
        }


        static IContainer InitializeContainer(Assembly infrastructureAssembly)
        {
            var coreAssembly = typeof (UnleashedCore).Assembly;

            var builder = new ContainerBuilder();

            builder.RegisterAssemblyTypes(coreAssembly).SingleInstance();
            builder.RegisterAssemblyTypes(infrastructureAssembly).AsImplementedInterfaces().SingleInstance();

            builder.RegisterType<AccountingProviderFactory>().As<IAccountingProviderFactory>();

            builder.RegisterType<OrganizationContextFactory>().AsImplementedInterfaces();
            builder.RegisterType<HandlersConfiguration>().As<IHandlerDecisionMaker>();

            builder.RegisterType<InThreadStack>().As<IStack>();
            builder.RegisterType<AutofacInstantiator>().As<ITypeInstantiator>();
            builder.RegisterType<DomainAssemblyProvider>().AsImplementedInterfaces().SingleInstance();

            builder.RegisterType<Core>().SingleInstance();
            builder.RegisterType<UnleashedCore>().SingleInstance();

            builder.RegisterType<AzureConfiguration>().As<IAzureConfiguration>();

            return builder.Build();
        }
    }
}
