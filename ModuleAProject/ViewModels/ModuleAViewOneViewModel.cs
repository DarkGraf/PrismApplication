using InterfacesProject;
using System;

namespace ModuleAProject.ViewModels
{
    public class ModuleAViewOneViewModel
    {
        ITextService textService;

        public ModuleAViewOneViewModel(ITextService textService)
        {
            this.textService = textService;
        }

        public string Text
        {
            get
            {
                return textService.GetText();
            }
            set
            {

            }
        }
    }
}