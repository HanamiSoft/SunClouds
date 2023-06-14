using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SunClouds.ViewModel.Helpers
{
    /// <summary>
    /// Класс-помощник для биндинга(привязки) ваших свойств из ViewModel во View, в MVVM.
    /// </summary>
    internal class BindingHelper : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
