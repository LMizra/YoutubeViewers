using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTubeViewers.WPF.Models;
using YouTubeViewers.WPF.Stores;

namespace YouTubeViewers.WPF.ViewModels
{
    public class YouTubeViewersDetailsViewModel : ViewModelBase
    {
        private readonly SelectedYouTubeViewerStore _selectedYouTubeViewerStore;

        private YouTubeViewer SelectedYouTubeViewer => _selectedYouTubeViewerStore.SelectedYouTubeViewer;

        // UI shouldnt display the data if no user is selected

        public bool HasSelectedYouTuberViewer => SelectedYouTubeViewer != null;
        public string Username => SelectedYouTubeViewer?.Username ?? "Unknown";
        public string IsSubscribedDisplay => (SelectedYouTubeViewer?.IsSubscribed ?? false) ? "Yes" : "No";
        public string IsMemberDisplay => (SelectedYouTubeViewer?.IsMember ?? false) ? "Yes" : "No"; 

        public YouTubeViewersDetailsViewModel(SelectedYouTubeViewerStore selectedYouTubeViewerStore)
        {
            _selectedYouTubeViewerStore = selectedYouTubeViewerStore;

            _selectedYouTubeViewerStore.SelectedYouTubeViewerChanged += _selectedYouTubeViewerStore_SelectedYouTubeViewerChanged;
        }

        //'YouTubeViewersDetailsViewModel will never be able to clean up as it always has a reference to the store so it would need to be disposed.
        protected override void Dispose()
        {
            _selectedYouTubeViewerStore.SelectedYouTubeViewerChanged += _selectedYouTubeViewerStore_SelectedYouTubeViewerChanged;
        }

        private void _selectedYouTubeViewerStore_SelectedYouTubeViewerChanged()
        {
            OnPropertyChanged(nameof(HasSelectedYouTuberViewer));
            OnPropertyChanged(nameof(Username));
            OnPropertyChanged(nameof(IsSubscribedDisplay));
            OnPropertyChanged(nameof(IsMemberDisplay));
            

        }
    }
}
