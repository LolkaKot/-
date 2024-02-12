using System.Configuration;
using System.Data;
using System.Windows;

namespace WpfApp12
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
           new MainWindow().Show();
        }
    }

}
