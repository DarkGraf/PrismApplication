using InterfacesProject;

namespace ModuleBProject.ViewModels
{
    public class ModuleBViewOneViewModel
    {
        ITextService textService;

        public ModuleBViewOneViewModel(ITextService textService)
        {
            this.textService = textService;
        }

        public string Text
        {
            get
            {
                return textService.GetText().Split(' ')[0];
            }
        }
    }
}