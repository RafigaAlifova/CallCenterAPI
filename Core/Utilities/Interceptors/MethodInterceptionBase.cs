using Castle.DynamicProxy;
using System;

namespace Core.Utilities.Interceptors
{
    [Serializable] // running zamani elcatanliq
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, 
        AllowMultiple = true, Inherited = true)]
    public abstract class MethodInterceptionBaseAttribute : Attribute, IInterceptor
    {
        public int Priority { get; set; } //bir nece aspect olanda siraliyaciyiq istesek tutalim ilk logla sonra cach ele fln. istemesek vermerik default goturer idk

        public virtual void Intercept(IInvocation invocation)
        {
            
        }
    }
}
