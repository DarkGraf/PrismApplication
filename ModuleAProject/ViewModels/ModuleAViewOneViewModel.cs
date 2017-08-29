using InterfacesProject;
using Prism.Commands;
using Prism.Events;
using System;
using System.ComponentModel;
using System.Windows.Input;

namespace ModuleAProject.ViewModels
{
    public class ModuleAViewOneViewModel : INotifyPropertyChanged
    {
        ITextService textService;
        IEventAggregator eventAggregator;

        public ModuleAViewOneViewModel(ITextService textService, IEventAggregator eventAggregator)
        {
            this.textService = textService;
            this.eventAggregator = eventAggregator;
        }

        public string Text
        {
            get
            {
                return textService.GetText();
            }
        }

        public ICommand changeTextCommand;

        public ICommand ChangeTextCommand
        {
            get
            {
                if (changeTextCommand == null)
                {
                    changeTextCommand = new DelegateCommand<string>(OnChangeCommandExecute);
                }
                return changeTextCommand;
            }
        }

        private void OnChangeCommandExecute(string newText)
        {
            textService.SetText(newText);

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Text"));

            TextChangedEvent evt = eventAggregator.GetEvent<TextChangedEvent>();
            evt.Publish(textService.GetText());
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}