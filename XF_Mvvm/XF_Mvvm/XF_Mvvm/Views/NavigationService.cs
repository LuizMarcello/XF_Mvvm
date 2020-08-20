using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XF_Mvvm.ViewModels;

namespace XF_Mvvm.Views
{
    public class NavigationService : INavigationService
    {
        public async Task NavegarParaLogin()
        {
           await App.Current.MainPage.Navigation.PushAsync(new LoginView());
        }

        public async Task NavegarParaMenu()
        {
            await App.Current.MainPage.Navigation.PushAsync(new MenuView());
        }

        public async Task NavegarParaRegistro()
        {
            await App.Current.MainPage.Navigation.PushAsync(new RegistroView());
        }
    }
}
