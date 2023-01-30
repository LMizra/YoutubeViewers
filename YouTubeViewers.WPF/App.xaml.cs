using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using YouTubeViewers.WPF.ViewModels;

namespace YouTubeViewers.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {

                DataContext = new YouTubeViewersViewModel() //this pulls the YouTubeViewersViewModel class and all its methods so it shows on startup.

            };
                
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
