using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YouTubeViewers.WPF.Models;

namespace YouTubeViewers.WPF.ViewModels
{

    //this is a list of YouTube Viewers -- Listing Items 
    public class YouTubeViewersListingItemViewModel :ViewModelBase
    {
        public YouTubeViewer YouTubeViewer { get; }
        public String Username => YouTubeViewer.Username;

        public ICommand EditCommand { get; }

        public ICommand DeleteCommand { get; }

        //constructor

        public YouTubeViewersListingItemViewModel(YouTubeViewer youTubeViewer)
        {
            this.YouTubeViewer = youTubeViewer;
        }


    }
}
