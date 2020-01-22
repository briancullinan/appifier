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
using MahApps.Metro.Controls;
using Winumeration;

namespace Metrofier
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ApplicationContent.Visibility = System.Windows.Visibility.Hidden;
            // do some stuff
            if (e.AddedItems.Contains(Recent))
            {
                Applications.ItemsSource = null;
            }
            else if (e.AddedItems.Contains(Running))
            {
                Applications.ItemsSource = Winumerator.TitledWindows;
            }
            else if (e.AddedItems.Contains(Metrofied))
            {
                Applications.ItemsSource = null;
            }
            ApplicationContent.Visibility = System.Windows.Visibility.Visible;
        }

        private void ApplicationContent_Loaded(object sender, RoutedEventArgs e)
        {
            List1.SelectionChanged += ListBox_SelectionChanged;
            List1.SelectedIndex = 0;
        }
    }
}
