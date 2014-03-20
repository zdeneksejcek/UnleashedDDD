using System;
using System.Reflection;
using Autofac;
using OpenDDD;
using OpenDDD.RemoteEventQueue;
using OpenDDD.UnitOfWorkContext;

namespace UnleashedDDD.Tests
{
    public class CoreInitializer
    {
        public static Core Initialize()
        {
            return new Core(
                new DomainAssemblyProvider(),
                new TestTypeInstantiator(),
                new HandlerDecisionMaker(),
                new NullRemoteQueue());
        }

        public class HandlerDecisionMaker : IHandlerDecisionMaker
        {
            public bool ShouldBeHandled(Type type)
            {
                return false;
            }
        }

        public class DomainAssemblyProvider : IDomainAssemblyProvider
        {
            public Assembly[] GetDomainAssemblies()
            {
                return new[] {typeof (UnleashedCore).Assembly};
            }
        }

        public class TestTypeInstantiator : ITypeInstantiator
        {
            private IContainer _container;

            public TestTypeInstantiator()
            {
                _container = InitializeContainer();
            }

            private IContainer InitializeContainer()
            {
                var builder = new ContainerBuilder();

                builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).AsImplementedInterfaces().SingleInstance();
                builder.RegisterAssemblyTypes(typeof(UnleashedDDD.Sales.SalesFacade).Assembly).SingleInstance();

                //builder.RegisterType<AccountingProviderFactory>().As<IAccountingProviderFactory>();

                //builder.RegisterType<OrganizationContextFactory>().AsImplementedInterfaces();
                //builder.RegisterType<HandlersConfiguration>().As<IHandlerDecisionMaker>();

                builder.RegisterType<InThreadStack>().As<IStack>();
                builder.RegisterType<TestTypeInstantiator>().As<ITypeInstantiator>();
                builder.RegisterType<DomainAssemblyProvider>().AsImplementedInterfaces().SingleInstance();

                builder.RegisterType<Core>().SingleInstance();
                builder.RegisterType<UnleashedCore>().SingleInstance();

                return builder.Build();
                
            }
            
            public T Instantiate<T>(Type type)
            {
                return (T)_container.Resolve(type);
            }

            public object Instantiate(Type type)
            {
                return _container.Resolve(type);
            }

            public T Instantiate<T>()
            {
                return _container.Resolve<T>();
            }
        }

        public class NullRemoteQueue : IRemoteEventQueue
        {
            public void Enqueue(Event @event)
            {
                
            }
        }
    }
}
