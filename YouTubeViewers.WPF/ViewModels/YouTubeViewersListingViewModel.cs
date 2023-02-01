using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouTubeViewers.WPF.Models;
using YouTubeViewers.WPF.Stores;

namespace YouTubeViewers.WPF.ViewModels
{
   public class YouTubeViewersListingViewModel : ViewModelBase
    {
        private readonly SelectedYouTubeViewerStore _selectedYouTubeViewerStore;
        private readonly ObservableCollection<YouTubeViewersListingItemViewModel> _youTubeViewersListingItemViewModels; // OC it will automatomatically update whenever we add/remove from an OB
        
        public IEnumerable<YouTubeViewersListingItemViewModel> YouTubeViewersListingItemViewModels => _youTubeViewersListingItemViewModels; //grabs the list from the view model and imports it here.

        private YouTubeViewersListingItemViewModel _selectedYouTubeViewersListingItemViewModel; //items in out listview = 'YouTubeViewersListingItemViewModel.
        public YouTubeViewersListingItemViewModel SelectedYouTubeViewerListingItemViewModel
        {
            get
            {
                return _selectedYouTubeViewersListingItemViewModel;
            }
            set
            {
                _selectedYouTubeViewersListingItemViewModel= value;
                OnPropertyChanged(nameof(SelectedYouTubeViewerListingItemViewModel));

                _selectedYouTubeViewerStore.SelectedYouTubeViewer = _selectedYouTubeViewersListingItemViewModel.YouTubeViewer;
            }
        }

        //whenever the above changes it needs to update in the '_selectedYouTubeViewerStore '

        public YouTubeViewersListingViewModel(SelectedYouTubeViewerStore selectedYouTubeViewerStore)
        {
            _selectedYouTubeViewerStore = selectedYouTubeViewerStore;
            _youTubeViewersListingItemViewModels = new ObservableCollection<YouTubeViewersListingItemViewModel>
            {
                new YouTubeViewersListingItemViewModel(new YouTubeViewer( "Mary", true, false)),
                new YouTubeViewersListingItemViewModel(new YouTubeViewer("Sean", false, false)),
            new YouTubeViewersListingItemViewModel(new YouTubeViewer("Alan", true, true))
            };
            
        }
    }

}
