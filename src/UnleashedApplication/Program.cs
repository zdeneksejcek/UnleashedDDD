using System;
using Autofac;
using OpenDDD;
using OpenDDD.UnitOfWorkContext;
using UnleashedDDD;
using UnleashedDDD.Accounting.Port;
using UnleashedDDD.Infrastructure.InMemory.Multitenent;
using UnleashedDDD.Inventory.Application.Commands;
using UnleashedDDD.Main;
using UnleashedDDD.Organizations.Application.Commands;
using UnleashedDDD.Sales.Application.Commands;

namespace UnleashedApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = InitializeContainer();

            var core = container.Resolve<UnleashedCore>();

            core.Organizations.RegisterNewUser(new NewUserCommand("zdenek@sejcek.cz", "Zdenek", "Sejcek"));

            var newOrganization = core.Organizations.RegisterNewOrganization(new NewOrganizationCommand(Guid.NewGuid(), "My super trooper Org"));

            var so = core.Sales.CreateNewSalesOrder(new NewSalesOrderCommand(Guid.NewGuid(), Guid.NewGuid()));

            using (var uow = new UnitOfWork())
            {
                var model = core.Inventory.CreateNewWarehouse(new NewWarehouseCommand("Warehouse"));

                uow.Commit();
            }
            
            Console.ReadLine();
        }

        static IContainer InitializeContainer()
        {
            var coreAssembly = typeof (UnleashedCore).Assembly;
            var infrastructureAssembly = typeof (Queue).Assembly;

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

            return builder.Build();
        }
    }
}
