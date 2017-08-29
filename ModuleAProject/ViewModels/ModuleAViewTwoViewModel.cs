using InterfacesProject;
using Prism.Events;
using Prism.Regions;
using System;
using System.ComponentModel;

namespace ModuleAProject.ViewModels
{
    public class ModuleAViewTwoViewModel : INotifyPropertyChanged
    {
        IRegionManager regionManager;

        public ModuleAViewTwoViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;

            regionManager.Regions["ParentRegion"].PropertyChanged += (s, e) =>
            {
                if (e.PropertyName == "Context")
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Text"));
                }
            };
        }

        public int Text
        {
            get
            {
                return (regionManager.Regions["ParentRegion"].Context as string).Length;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}