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

                _selectedYouTubeViewerStore.SelectedYouTubeViewer = _selectedYouTubeViewersListingItemViewModel?.YouTubeViewer;
            }
        }

        //whenever the above changes it needs to update in the '_selectedYouTubeViewerStore '

        //add a 'YouTubeViewersListingItemViewModel' to the list '_youTubeViewersListingItemViewModels ' and then the 'YouTubeViewersListingItemViewModel' takes ' YouTubeViewer'
        // so now in the 'YouTubeViewersListingItemViewModel'file the 'YouTubeViewer' is defined there. Which means whenever the 'selectedYouTubeViewer' is chosen you will get the 
        // '_selectedYouTubeViewersListingItemViewModel' and the ' YouTubeViewer' line 31. which is then passed to the 'SelectedYouTubeViewerStore'
        //once its set in the store the public event is then raised/action which then passes the information to the 'YouTubeViewersDetailViewModel' which tells the viewmodel to refresh the data
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
