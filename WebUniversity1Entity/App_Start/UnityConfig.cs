using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using System;
using System.Web;
using DAL;
using BLL.Implementations;
using BLL.Interfaces;

namespace WebUniversity1Entity
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<UnitOfWork>(new PerHttpRequestLifetime());
            container.RegisterType<IGroupManager, GroupManager>();
            container.RegisterType<IGroupSubjectManager, GroupSubjectManager>();
            container.RegisterType<IStudentManager, StudentManager>();
            container.RegisterType<ISubjectManager, SubjectManager>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        public class PerHttpRequestLifetime : LifetimeManager
        {
            // This is very important part and the reason why I believe mentioned
            // PerCallContext implementation is wrong.
            private readonly Guid _key = Guid.NewGuid();

            public override object GetValue()
            {
                return HttpContext.Current.Items[_key]; 
            }

            public override void SetValue(object newValue)
            {
                HttpContext.Current.Items[_key] = newValue;
            }

            public override void RemoveValue()
            {
                var obj = GetValue();
                HttpContext.Current.Items.Remove(obj);
            }
        }
    }
}