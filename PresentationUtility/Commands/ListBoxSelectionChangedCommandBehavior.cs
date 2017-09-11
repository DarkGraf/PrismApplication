using Prism.Interactivity;
using System.Windows;
using System.Windows.Controls;

namespace PresentationUtility.Commands
{
    public class ListBoxSelectionChangedCommandBehavior : CommandBehaviorBase<ListBox>
    {
        public ListBoxSelectionChangedCommandBehavior(ListBox listBox) : base(listBox)
        {
            listBox.SelectionChanged += SelectionChangedHandler;
        }

        private void SelectionChangedHandler(object sender, SelectionChangedEventArgs e)
        {
#warning Здесь в примере не было параметра.
            ExecuteCommand(null);
        }
    }
}