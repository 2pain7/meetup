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

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            StackPanel stackPanel = new StackPanel();

            TextBox textBox1 = new TextBox();
            TextBox textBox2 = new TextBox();
            TextBlock textBlock1 = new TextBlock {
                FontWeight = FontWeights.Bold
            };
            TextBlock textBlock2 = new TextBlock {
                FontWeight = FontWeights.Bold
            };

            textBlock1.Text = "Начало";
            textBlock2.Text = "Конец";

            stackPanel.Children.Add(textBlock1);
            stackPanel.Children.Add(textBox1);
            stackPanel.Children.Add(textBlock2);
            stackPanel.Children.Add(textBox2);
            

            Button deleteButton = new Button {
                Background = new SolidColorBrush(Colors.LightBlue),
                BorderThickness = new Thickness(0),
                FontWeight = FontWeights.Bold,
                Foreground = new SolidColorBrush(Colors.DarkBlue),
            };
            deleteButton.Content = "Удалить";
            deleteButton.Click += (s, ev) => { stack.Children.Remove(stackPanel); };
            stackPanel.Children.Add(deleteButton);

            stack.Children.Add(stackPanel);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            name.Text = null;
            place.Text = null;
            date.Text = null;
            content.Text = null;
            img1.Source = null;
            stack.Children.Clear();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string a = name.Text;
            string b = place.Text;
            string c = date.Text;
            string d = content.Text;
          
            if (string.IsNullOrWhiteSpace(a) || string.IsNullOrWhiteSpace(b) || string.IsNullOrWhiteSpace(c) || string.IsNullOrWhiteSpace(d))
            {
                 MessageBox.Show("Заполните все поля!","Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show($" Введено: \n Название: {a} \n Место: {b} \n Дата: {c} \n Описание: {d}...", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }
    }
}
