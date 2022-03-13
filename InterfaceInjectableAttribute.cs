using System;

namespace Snap.Core.DependencyInjection
{
    public abstract class InterfaceInjectableAttribute : InjectableAttribute 
    {
        /// <summary>
        /// 该类实现的接口类型
        /// </summary>
        public Type InterfaceType { get; set; } = default!;
    }
}
