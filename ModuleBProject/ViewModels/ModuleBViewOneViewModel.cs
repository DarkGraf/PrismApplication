using InterfacesProject;
using Prism.Events;
using System.ComponentModel;
using System;
using Prism.Regions;

namespace ModuleBProject.ViewModels
{
    public class ModuleBViewOneViewModel : INotifyPropertyChanged
    {
        IRegionManager regionManager;

        public ModuleBViewOneViewModel(IRegionManager regionManager)
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

        public string Text
        {
            get
            {
                return (regionManager.Regions["ParentRegion"].Context as string).Split(' ')[0];
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}