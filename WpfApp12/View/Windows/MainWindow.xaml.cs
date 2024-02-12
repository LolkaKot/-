using System.Windows;
using WpfApp12.Core;
using WpfApp12.View.Pages;

namespace WpfApp12
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainCoreNav.MainNavCore = MainFrame;
        }

        private void BtnTask1_Click(object sender, RoutedEventArgs e)
        {
            MainCoreNav.MainNavCore.Navigate(new Task1Page());
        }

        private void BtnTask2_Click(object sender, RoutedEventArgs e)
        {
            MainCoreNav.MainNavCore.Navigate(new Tasl2Page());
        }
    }
}