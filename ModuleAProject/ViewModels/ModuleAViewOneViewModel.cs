using InterfacesProject;
using Prism.Commands;
using System;
using System.ComponentModel;
using System.Windows.Input;

namespace ModuleAProject.ViewModels
{
    public class ModuleAViewOneViewModel : INotifyPropertyChanged
    {
        ITextService textService;

        public ModuleAViewOneViewModel(ITextService textService)
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
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}