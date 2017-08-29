using System;

namespace InterfacesProject
{
    public interface ITextService
    {
        string GetText();
        void SetText(string newValue);

        event EventHandler TextChanged;
    }
}