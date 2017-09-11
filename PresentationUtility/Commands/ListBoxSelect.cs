using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace PresentationUtility.Commands
{
    public class ListBoxSelect
    {
        public static readonly DependencyProperty CommandProperty =
            DependencyProperty.RegisterAttached("Command", typeof(ICommand), typeof(ListBoxSelect), new PropertyMetadata(OnSetCommandCallback));

        public static readonly DependencyProperty CommandParameterProperty =
            DependencyProperty.RegisterAttached("CommandParameter", typeof(object), typeof(ListBoxSelect), new PropertyMetadata(OnSetCommandParameterCallback));

        private static readonly DependencyProperty SelectCommandBehaviorProperty =
            DependencyProperty.RegisterAttached("SelectCommandBehavior", typeof(object), typeof(ListBoxSelect), null);

        private static void OnSetCommandCallback(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {
            ListBox lb = dependencyObject as ListBox;

            if (lb != null)
            {
                ListBoxSelectionChangedCommandBehavior behavior = GetOrCreateBehavior(lb);
                behavior.Command = e.NewValue as ICommand;
            }
        }

        private static void OnSetCommandParameterCallback(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {
            ListBox lb = dependencyObject as ListBox;

            if (lb != null)
            {
                ListBoxSelectionChangedCommandBehavior behavior = GetOrCreateBehavior(lb);
                behavior.CommandParameter = e.NewValue;
            }
        }

        private static ListBoxSelectionChangedCommandBehavior GetOrCreateBehavior(ListBox listBox)
        {
            ListBoxSelectionChangedCommandBehavior behavior =
                listBox.GetValue(SelectCommandBehaviorProperty) as ListBoxSelectionChangedCommandBehavior;

            if (behavior == null)
            {
                behavior = new ListBoxSelectionChangedCommandBehavior(listBox);
                listBox.SetValue(SelectCommandBehaviorProperty, behavior);
            }
            return behavior;
        }

        public static ICommand GetCommand(ListBox listBox)
        {
            return listBox.GetValue(CommandProperty) as ICommand;
        }

        public static void SetCommand(ListBox listBox, ICommand command)
        {
            listBox.SetValue(CommandProperty, command);
        }

        public static object GetCommandParameter(ListBox listBox)
        {
            return listBox.GetValue(CommandParameterProperty);
        }

        public static void SetCommandParameter(ListBox listBox, object parameter)
        {
            listBox.SetValue(CommandParameterProperty, parameter);
        }
    }
}