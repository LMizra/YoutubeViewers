using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeViewers.WPF.ViewModels
{
   public class YouTubeViewersListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<YouTubeViewersListingItemViewModel> _youTubeViewersListingItemViewModels; // OC it will automatomatically update whenever we add/remove from an OB
        public IEnumerable<YouTubeViewersListingItemViewModel> YouTubeViewersListingItemViewModels => _youTubeViewersListingItemViewModels; //grabs the list from the view model and imports it here.

        public YouTubeViewersListingViewModel()
        {
            _youTubeViewersListingItemViewModels = new ObservableCollection<YouTubeViewersListingItemViewModel>
            {
                new YouTubeViewersListingItemViewModel("Mary"),
                new YouTubeViewersListingItemViewModel("Sean"),
                new YouTubeViewersListingItemViewModel("Alan")
            };

        }
    }

}
