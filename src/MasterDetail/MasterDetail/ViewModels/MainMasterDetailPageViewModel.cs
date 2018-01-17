using Prism.Commands;
using Prism.Navigation;

namespace MasterDetail.ViewModels
{
    public class MainMasterDetailPageViewModel : ViewModelBase
    {
        public DelegateCommand<string> NavigateCmd { get; }

        public MainMasterDetailPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            NavigateCmd = new DelegateCommand<string>((page) =>
            {
                NavigationService.NavigateAsync($"{page}");
            });
        }
    }
}
