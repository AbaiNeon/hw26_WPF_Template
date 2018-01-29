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

namespace hw26_WPF_Template
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

        private void ButtonOneClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ok");
        }

        private void ButtonTwoClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ok");
        }

        private void ButtonThreeClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ok");
        }
    }
}
