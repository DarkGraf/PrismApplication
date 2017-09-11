using Prism.Interactivity;
using System.Windows;
using System.Windows.Controls;

namespace PresentationUtility.Commands
{
    public class TreeViewSelectionChangedCommandBehavior : CommandBehaviorBase<TreeView>
    {
        public TreeViewSelectionChangedCommandBehavior(TreeView treeView) : base(treeView)
        {
            treeView.SelectedItemChanged += SelectionChangedHandler;
        }

        private void SelectionChangedHandler(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
#warning Здесь в примере не было параметра.
            ExecuteCommand(null);
        }
    }
}