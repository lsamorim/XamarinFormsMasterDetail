using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasterDetail.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public DelegateCommand<string> NavigateCmd { get; set; }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Master Detail Sample";

            NavigateCmd = new DelegateCommand<string>(NavigateToDetails);
        }

        private void NavigateToDetails(string val)
        {
            switch (int.Parse(val))
            {
                case 1:
                    NavigationService.NavigateAsync("DetailsPage");
                    break;
                case 2:
                    NavigationService.NavigateAsync("/DetailsPage");
                    break;
                case 3:
                    NavigationService.NavigateAsync("DetailsPage", useModalNavigation: true);
                    break;
                case 4:
                    NavigationService.NavigateAsync("/DetailsPage", useModalNavigation: true);
                    break;

                case 5:
                    NavigationService.NavigateAsync("NavigationPage/DetailsPage");
                    break;
                case 6:
                    NavigationService.NavigateAsync("/NavigationPage/DetailsPage");
                    break;
                case 7:
                    NavigationService.NavigateAsync("NavigationPage/DetailsPage", useModalNavigation: true);
                    break;
                case 8:
                    NavigationService.NavigateAsync("/NavigationPage/DetailsPage", useModalNavigation: true);
                    break;
            }
        }
    }
}
