using System.Diagnostics;

namespace AutofacSampleCalculator.Core.ServiceLocator
{
    public interface IServiceLocator
    {
        [DebuggerStepThrough]
        T Resolve<T>();
    }
}
