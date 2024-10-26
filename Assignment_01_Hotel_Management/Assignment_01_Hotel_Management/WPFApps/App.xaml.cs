using Assignment_01_Hotel_Management.WPFApps;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Assignment_01_Hotel_Management
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        [STAThread]  // Required for WPF
        public static void Main()
        {
            var app = new App();
            app.Run(new LoginWindow());  // Start with Login Window
        }
    }

}
