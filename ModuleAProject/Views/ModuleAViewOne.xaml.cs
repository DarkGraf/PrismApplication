using ModuleAProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ModuleAProject
{
    /// <summary>
    /// Interaction logic for ModuleAViewOne.xaml
    /// </summary>
    public partial class ModuleAViewOne : UserControl
    {
        public ModuleAViewOne(ModuleAViewOneViewModel model)
        {
            InitializeComponent();

            Loaded += (s, e) =>
            {
                DataContext = model;
            };
        }
    }
}
