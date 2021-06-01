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
using TransitionsExample.ViewModel;

namespace TransitionsExample.View
{
    /// <summary>
    /// Interaction logic for Slide2.xaml
    /// </summary>
    public partial class Slide2 : UserControl
    {
        public Slide2(MainViewModel mainVM)
        {
            InitializeComponent();
            DataContext = new Slide2ViewModel(mainVM);
        }
    }
}
