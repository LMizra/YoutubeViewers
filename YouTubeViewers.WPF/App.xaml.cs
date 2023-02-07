using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using YouTubeViewers.WPF.Stores;
using YouTubeViewers.WPF.ViewModels;

namespace YouTubeViewers.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ModalNavigationStore _modalNavigationStore; //defining the store
        private readonly SelectedYouTubeViewerStore _selectedYouTubeViewerStore; //single source of truth so only 1 store. being defined here, being passed down through application 'app'

        public App()
        {
            _modalNavigationStore = new ModalNavigationStore();
            _selectedYouTubeViewerStore= new SelectedYouTubeViewerStore();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            YouTubeViewersViewModel youTubeViewersViewModel = new YouTubeViewersViewModel(_selectedYouTubeViewerStore, _modalNavigationStore);

            MainWindow = new MainWindow()
            {

                DataContext =new MainViewModel(_modalNavigationStore, youTubeViewersViewModel) //this pulls the YouTubeViewersViewModel class and all its methods so it shows on startup.

            };
                
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
