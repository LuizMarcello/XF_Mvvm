using Xamarin.Forms;
using XF_Mvvm.Views;

namespace XF_Mvvm
{
    public partial class App : Application
    {
        public App()
        {
            //Registrando a interface(onde ela está) e sua implementação(a classe que implementou ela)
            //no serviço de dependência. Utilização do "dependency Service".
            DependencyService.Register<ViewModels.IMessageService, Views.MessageService>();

            InitializeComponent();

            MainPage = new NavigationPage(new LoginView());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
       

        
