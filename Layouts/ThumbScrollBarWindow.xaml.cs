using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Layouts
{
    /// <summary>
    /// Lógica de interacción para ThumbScrollBarWindow.xaml
    /// </summary>
    public partial class ThumbScrollBarWindow : Window
    {
        public ThumbScrollBarWindow()
        {
            InitializeComponent();
        }
        private void OnDragDelta(object sender, DragDeltaEventArgs e)
        {
            Canvas.SetLeft(myThumb, Canvas.GetLeft(myThumb) + e.HorizontalChange);
            Canvas.SetTop(myThumb, Canvas.GetTop(myThumb) + e.VerticalChange);
            txtPosition.Text = $"Position: {Canvas.GetLeft(myThumb)},{Canvas.GetTop(myThumb)}";
        }
        private void OnDragStarted(object sender, DragStartedEventArgs e)
        {
            myThumb.Background = Brushes.Orange;
        }
        private void OnDragCompleted(object sender, DragCompletedEventArgs e)
        {
            myThumb.Background = Brushes.Blue;
        }
        private void ScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            Canvas.SetLeft(myThumb, 100 + e.NewValue);
        }
    }
}
