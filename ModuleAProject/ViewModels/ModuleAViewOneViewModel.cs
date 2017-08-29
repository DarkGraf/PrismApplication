using InterfacesProject;
using Prism.Commands;
using Prism.Events;
using Prism.Regions;
using System;
using System.ComponentModel;
using System.Windows.Input;

namespace ModuleAProject.ViewModels
{
    public class ModuleAViewOneViewModel : INotifyPropertyChanged
    {
        IRegionManager regionManager;

        public ModuleAViewOneViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public string Text
        {
            get
            {
                return regionManager.Regions["ParentRegion"].Context as string;
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
            regionManager.Regions["ParentRegion"].Context = newText;

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Text"));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}