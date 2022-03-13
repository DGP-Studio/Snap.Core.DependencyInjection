using System;

namespace Snap.Core.DependencyInjection
{
    /// <summary>
    /// 指示该类为视图
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class ViewAttribute : InjectableAttribute
    {
        /// <summary>
        /// 指示该类为视图
        /// </summary>
        public ViewAttribute(InjectAs injectAs)
        {
            InjectAs = injectAs;
        }
    }
}
