﻿using System;
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
using Pathfinder.UI.ViewModels;

namespace Pathfinder.UI.Views
{
    /// <summary>
    /// Interaction logic for PathfinderControlView.xaml
    /// </summary>
    public partial class PathfinderControlView : UserControl
    {
        public PathfinderControlView(PathfinderViewModel viewModel)
        {
            InitializeComponent();
            ViewModel = viewModel;
        }

        public PathfinderViewModel ViewModel 
        {
            get { return (PathfinderViewModel)DataContext; }
            set { DataContext = value;}
        }
    }
}