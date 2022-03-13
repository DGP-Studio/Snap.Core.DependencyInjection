using System;

namespace Snap.Core.DependencyInjection
{
    /// <summary>
    /// 指示该类为工厂
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class FactoryAttribute : InterfaceInjectableAttribute
    {
        /// <summary>
        /// 指示该类为服务
        /// </summary>
        /// <param name="impl">实现的接口类型</param>
        public FactoryAttribute(Type impl, InjectAs injectAs)
        {
            InterfaceType = impl;
            InjectAs = injectAs;
        }
    }
}
