using InterfacesProject;
using System;
using System.ComponentModel;

namespace ModuleAProject.ViewModels
{
    public class ModuleAViewTwoViewModel : INotifyPropertyChanged
    {
        ITextService textService;

        public ModuleAViewTwoViewModel(ITextService textService)
        {
            this.textService = textService;
            this.textService.TextChanged += (s, e) =>
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Text"));
            };
        }

        public int Text
        {
            get
            {
                return textService.GetText().Length;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}