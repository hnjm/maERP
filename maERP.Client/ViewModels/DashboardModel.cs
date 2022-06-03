﻿#nullable disable

using maERP.Client.Contracts;

namespace maERP.Client.ViewModels
{
    public class DashboardModel : ViewModelBase
    {
        readonly INavigationService _navigationService;

        public DashboardModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}