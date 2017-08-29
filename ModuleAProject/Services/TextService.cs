using System;
using InterfacesProject;

namespace ModuleAProject
{
    public class TextService : ITextService
    {
        string text;

        public TextService()
        {
            text = "Hello World";
        }

        public string GetText()
        {
            return text;
        }

        public void SetText(string newValue)
        {
            text = newValue;
            TextChanged?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler TextChanged;
    }
}