using System;

namespace Snap.Core.DependencyInjection
{
    /// <summary>
    /// 表示可注入特性
    /// </summary>
    public abstract class InjectableAttribute : Attribute
    {
        /// <summary>
        /// 注入类型
        /// </summary>
        public InjectAs InjectAs { get; set; }
    }
}