﻿using System;

namespace Snap.Core.DependencyInjection
{
    /// <summary>
    /// 指示该类为服务
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class ServiceAttribute : InterfaceInjectableAttribute
    {
        /// <summary>
        /// 指示该类为服务
        /// </summary>
        /// <param name="impl">实现的接口类型</param>
        public ServiceAttribute(Type impl, InjectAs injectAs)
        {
            this.InterfaceType = impl;
            this.InjectAs = injectAs;
        }
    }
}
