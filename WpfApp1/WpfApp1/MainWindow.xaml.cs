using Microsoft.Win32;
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

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           tabControl.SelectedIndex = 1;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog saveimg = new OpenFileDialog { };
            saveimg.Filter = "Image file (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp";
            if (saveimg.ShowDialog() == true)
            {
                img1.Source = new BitmapImage(new Uri(saveimg.FileName));
            }
            update.Visibility = Visibility.Hidden;
            delete.Visibility = Visibility.Visible;
        }
        private void delete_Click_1(object sender, RoutedEventArgs e)
        {
            img1.Source = null;
            update.Visibility = Visibility.Visible;
            delete.Visibility = Visibility.Hidden;
        }
    }
}
