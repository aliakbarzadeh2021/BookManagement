using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Dependencies;
using Castle.MicroKernel.Lifestyle;
using Castle.Windsor;

namespace ServiceHost.Resolver
{
    public class DefaultDependencyScope : IDependencyScope
    {
        public DefaultDependencyScope(IWindsorContainer container)
        {
            Container = container;
            Scope = container.BeginScope();
        }

        public IDisposable Scope { get; private set;}
        public IWindsorContainer Container { get; private set; }

        public object GetService(Type serviceType)
        {
            return Container.Kernel.HasComponent(serviceType) ? Container.Resolve(serviceType) : null;
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return Container.ResolveAll(serviceType).Cast<object>();
        }

        public void Dispose()
        {
            Scope.Dispose();
        }
    }
}
