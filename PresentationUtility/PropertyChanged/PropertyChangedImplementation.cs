using System.ComponentModel;

namespace PresentationUtility.PropertyChanged
{
#warning Заменить на BindableBase
    public class PropertyChangedImplementation : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void FirePropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}