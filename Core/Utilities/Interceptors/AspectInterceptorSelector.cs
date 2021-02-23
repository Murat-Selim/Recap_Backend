using Castle.DynamicProxy;
using System;
using System.Linq;
using System.Reflection;

namespace Core.Utilities.Interceptors
{
    public class AspectInterceptorSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            var classAttributes = type.GetCustomAttributes<MethodInterceptionBaseAttribute>  //Git class ın Attribute lerini oku.Liste haline getir.
                (true).ToList();
            var methodAttributes = type.GetMethod(method.Name)  //Git Metodun Attribute lerini oku.
                .GetCustomAttributes<MethodInterceptionBaseAttribute>(true);
            classAttributes.AddRange(methodAttributes);


            return classAttributes.OrderBy(x => x.Priority).ToArray();  //Onların çalışma sırasını da Öncelik değerine göre sırala.
        }
    }
}
