using InterfacesProject;
using Prism.Events;
using System;
using System.ComponentModel;

namespace ModuleAProject.ViewModels
{
    public class ModuleAViewTwoViewModel : INotifyPropertyChanged
    {
        ITextService textService;

        public ModuleAViewTwoViewModel(ITextService textService, IEventAggregator eventAggregator)
        {
            this.textService = textService;
            TextChangedEvent evt = eventAggregator.GetEvent<TextChangedEvent>();
            evt.Subscribe(OnTextChangedReceived);
        }

        public void OnTextChangedReceived(string newText)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Text"));
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