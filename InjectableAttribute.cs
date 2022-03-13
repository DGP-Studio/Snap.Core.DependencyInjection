using System;

namespace Snap.Core.DependencyInjection
{
    public abstract class InjectableAttribute : Attribute 
    {
        public InjectAs InjectAs { get; set; }
    }
}
