using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YouTubeViewers.WPF.Stores;
using YouTubeViewers.WPF.ViewModels;

namespace YouTubeViewers.WPF.Commands
{
    internal class OpenAddYouTubeViewerCommand : CommandBase
    {

        private readonly ModalNavigationStore _modalNavigationStore;

        public OpenAddYouTubeViewerCommand(ModalNavigationStore modalNavigationStore)
        {
            _modalNavigationStore = modalNavigationStore;
        }

        public override void Execute(object? parameter)
        {
            AddYouTuberViewerViewModel addYouTubeViewerViewModel = new AddYouTuberViewerViewModel(); // this will now be displayed in the modal
            _modalNavigationStore.CurrentViewModel= addYouTubeViewerViewModel;
        }
    }
}
