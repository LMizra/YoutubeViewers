using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace YouTubeViewers.WPF.ViewModels
{
    class YouTubeViewerDetailsFormViewModel : ViewModelBase
    {
        private string _username;

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
                OnPropertyChanged(nameof(CanSubmit));

            }
        }

        private bool _isSubscribed;
        public bool IsSubscribed
        {
            get {
                return _isSubscribed;
            }
            set
            {
                _isSubscribed = value;
                OnPropertyChanged(nameof(IsSubscribed));
            }
        }

        private bool _isMemeber;
        public bool IsMemeber
        {
            get { return _isMemeber; }
            set { _isMemeber = value; OnPropertyChanged(nameof(IsMemeber)); }
        }
        public bool CanSubmit => !string.IsNullOrEmpty(Username);
        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }
    }
    
}
