using InterfacesProject;
using System.Windows;
using System.Windows.Controls;

namespace ModuleBProject
{
    public class UIService : IUIService
    {
        ITextService textService;

        public UIService(ITextService textService)
        {
            this.textService = textService;
        }

        public UIElement GetUI()
        {
            return new TextBlock
            {
                Text = textService.GetText()
            };
        }
    }
}