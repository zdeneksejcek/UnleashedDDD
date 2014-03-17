using System;
using Autofac;
using OpenDDD;

namespace UnleashedDDD.Main
{
    public class AutofacInstantiator : ITypeInstantiator
    {
        private IComponentContext _container;

        public AutofacInstantiator(IComponentContext container)
        {
            _container = container;
        }

        public T Instantiate<T>(Type type)
        {
            return (T)_container.Resolve(type);
        }

        public T Instantiate<T>()
        {
            return _container.Resolve<T>();
        }

        public object Instantiate(Type type)
        {
            return _container.Resolve(type);
        }
    }
}