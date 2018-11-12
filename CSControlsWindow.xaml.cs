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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для CSControlsWindow.xaml
    /// </summary>
    public partial class CSControlsWindow : Window
    {
        public CSControlsWindow()
        {
            InitializeComponent();
            Label label = new Label() { Content = "Label1" };
            Grid.SetColumn(label, 3);
            Grid.SetRow(label, 3);
            cSControlsGrid.RowDefinitions.Add(new RowDefinition());
            cSControlsGrid.RowDefinitions.Add(new RowDefinition());
            cSControlsGrid.RowDefinitions.Add(new RowDefinition());
            cSControlsGrid.ColumnDefinitions.Add(new ColumnDefinition());
            cSControlsGrid.ColumnDefinitions.Add(new ColumnDefinition());
            cSControlsGrid.ColumnDefinitions.Add(new ColumnDefinition());
            cSControlsGrid.Children.Add(label);
        }
    }
}
