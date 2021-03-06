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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void mainButton_Click(object sender, RoutedEventArgs e)
        {
            //mainLabel.Content = "New content";
            mainLabel.Content = mainTextBox.Text;
        }

        private void cSControlsButton_Click(object sender, RoutedEventArgs e)
        {
            CSControlsWindow cSControlsWindow = new CSControlsWindow();
            cSControlsWindow.ShowDialog();
        }
    }
}
