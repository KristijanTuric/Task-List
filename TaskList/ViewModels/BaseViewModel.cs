using System.ComponentModel;

namespace TaskList
{

    public class BaseViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// The event that is fired when any child property changes its value
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged = (sender, e) => { };
    }
}
