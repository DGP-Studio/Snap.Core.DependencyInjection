using System;

namespace Snap.Core.DependencyInjection
{
    /// <summary>
    /// 指示该类为服务
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class ServiceAttribute : Attribute
    {
        /// <summary>
        /// 指示该类为服务
        /// </summary>
        /// <param name="impl">实现的接口类型</param>
        public ServiceAttribute(Type impl, InjectAs injectAs)
        {
            InterfaceType = impl;
            InjectAs = injectAs;
        }

        /// <summary>
        /// 该类实现的接口类型
        /// </summary>
        public Type InterfaceType { get; set; }

        public InjectAs InjectAs { get; set; }
    }
}
