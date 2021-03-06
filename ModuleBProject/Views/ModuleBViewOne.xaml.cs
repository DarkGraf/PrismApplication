﻿using ModuleBProject.ViewModels;
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

namespace ModuleBProject
{
    /// <summary>
    /// Interaction logic for ModuleBViewOne.xaml
    /// </summary>
    public partial class ModuleBViewOne : UserControl
    {
        public ModuleBViewOne(ModuleBViewOneViewModel model)
        {
            InitializeComponent();

            Loaded += (s, e) =>
            {
                DataContext = model;
            };
        }
    }
}
