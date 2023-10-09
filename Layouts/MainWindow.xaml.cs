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

namespace Layouts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BulletDecoratorButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void CanvasButton_Click(object sender, RoutedEventArgs e)
        {
            CanvasWindow cWindow = new CanvasWindow();
            cWindow.Show();
        }

        private void ExpanderButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void GridButton_Click(object sender, RoutedEventArgs e)
        {
           GridWindow gWindow = new GridWindow();
            gWindow.Show();
        }

        private void StackPanelButton_Click(object sender, RoutedEventArgs e)
        {
            StackPanelWindow spWindow = new StackPanelWindow();
            spWindow.Show();
        }

        private void DockPanelButton_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void GridSplitterButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void GroupBoxButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ThumbButton_Click(object sender, RoutedEventArgs e)
        {
        }

        private void WrapPanelButton_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
