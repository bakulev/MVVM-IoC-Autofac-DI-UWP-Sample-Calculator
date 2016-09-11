using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;

namespace AutofacSampleCalculator.Models
{
    public interface IModel
        : INotifyPropertyChanged
    {
        string UserName { get; }
        string CompanyName { get; }

        int Summ(int a, int b);
    }
}
