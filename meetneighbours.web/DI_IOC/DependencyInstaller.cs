using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using meetneighbours.dal.Contracts;
using meetneighbours.dal.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;

namespace meetneighbours.web.DI_IOC
{
    public class DependencyInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(

                        Component.For<IDatabaseFactory>()
                            .ImplementedBy<DatabaseFactory>()
                            .LifeStyle.PerWebRequest,

                        Component.For<IUnitOfWork>()
                            .ImplementedBy<UnitOfWork>()
                            .LifeStyle.PerWebRequest,


                        Classes.FromThisAssembly().BasedOn<IHttpController>().LifestyleTransient(),

                        Classes.FromAssemblyNamed("meetneighbours.Services")
                            .Where(type => type.Name.EndsWith("Service")).WithServiceAllInterfaces().LifestylePerWebRequest(),

                        Classes.FromAssemblyNamed("meetneighbours.Repository")
                            .Where(type => type.Name.EndsWith("Repository")).WithServiceAllInterfaces().LifestylePerWebRequest()
                        );
        }

    }
}