using InterfacesProject;
using System;

namespace ModuleAProject.ViewModels
{
    public class ModuleAViewTwoViewModel
    {
        ITextService textService;

        public ModuleAViewTwoViewModel(ITextService textService)
        {
            this.textService = textService;
        }

        public int Text
        {
            get
            {
                return textService.GetText().Length;
            }
        }
    }
}