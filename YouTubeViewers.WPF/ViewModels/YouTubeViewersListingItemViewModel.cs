using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace YouTubeViewers.WPF.ViewModels
{

    //this is a list of YouTube Viewers -- Listing Items 
    public class YouTubeViewersListingItemViewModel :ViewModelBase
    {
        public String Username { get; }

        public ICommand EditCommand { get; }

        public ICommand DeleteCommand { get; }

        //constructor

        public YouTubeViewersListingItemViewModel(string username)
        {
            Username = username;
        }



    }
}
