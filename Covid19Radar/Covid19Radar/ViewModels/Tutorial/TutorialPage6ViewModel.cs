using System.Collections.Generic;
using Covid19Radar.Model;
using Covid19Radar.Renderers;
using Covid19Radar.Views;
using Prism.Navigation;
using Xamarin.Forms;
using Covid19Radar.Services;
using System.Threading.Tasks;

namespace Covid19Radar.ViewModels
{
    public class TutorialPage6ViewModel : ViewModelBase
    {
        private readonly UserDataService userDataService;
        private UserDataModel userData;

        public TutorialPage6ViewModel(INavigationService navigationService, UserDataService userDataService) : base(navigationService, userDataService)
        {
            this.userDataService = userDataService;            userData = this.userDataService.Get();
            TutorialComplete = TutorialCompleteAsync();
        }

        public Task TutorialComplete { get; private set; }

        private async Task TutorialCompleteAsync()
        {
            userData.IsPolicyAccepted = true;
            await userDataService.SetAsync(userData);
        }
    }
}