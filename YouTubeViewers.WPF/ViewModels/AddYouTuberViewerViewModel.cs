using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeViewers.WPF.ViewModels
{
    class AddYouTuberViewerViewModel : ViewModelBase
    {
        public YouTubeViewerDetailsFormViewModel YouTubeViewerDetailsFormViewModel { get; }

        public AddYouTuberViewerViewModel()
        {
            YouTubeViewerDetailsFormViewModel= new YouTubeViewerDetailsFormViewModel();
        } 
    }
}
