using InterfacesProject;
using System.ComponentModel;

namespace ModuleBProject.ViewModels
{
    public class ModuleBViewOneViewModel : INotifyPropertyChanged
    {
        ITextService textService;

        public ModuleBViewOneViewModel(ITextService textService)
        {
            this.textService = textService;
            this.textService.TextChanged += (s, e) =>
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Text"));
            };
        }

        public string Text
        {
            get
            {
                return textService.GetText().Split(' ')[0];
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}