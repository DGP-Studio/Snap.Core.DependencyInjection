using System;

namespace Snap.Core.DependencyInjection
{
    /// <summary>
    /// 指示该类为视图模型
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class ViewModelAttribute : Attribute
    {
        /// <summary>
        /// 指示该类为视图模型
        /// </summary>
        public ViewModelAttribute(InjectAs injectAs)
        {
            InjectAs = injectAs;
        }

        public InjectAs InjectAs { get; set; }
    }
}
