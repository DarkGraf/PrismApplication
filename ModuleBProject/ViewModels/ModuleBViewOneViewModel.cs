using InterfacesProject;
using Prism.Events;
using System.ComponentModel;
using System;

namespace ModuleBProject.ViewModels
{
    public class ModuleBViewOneViewModel : INotifyPropertyChanged
    {
        ITextService textService;

        public ModuleBViewOneViewModel(ITextService textService, IEventAggregator eventAggregator)
        {
            this.textService = textService;

            TextChangedEvent evt = eventAggregator.GetEvent<TextChangedEvent>();
            evt.Subscribe(OnTextChangedReceived);
        }

        private void OnTextChangedReceived(string newText)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Text"));
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