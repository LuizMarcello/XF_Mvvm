using Xamarin.Forms;
using XF_Mvvm.Views;

namespace XF_Mvvm
{
    public partial class App : Application
    {
        public App()
        {
            //Registrando as interfaces(onde elas estão) e suas implementações(as classes que implementam elas)
            //no serviço de dependência. Utilização do "dependency Service".

            DependencyService.Register<ViewModels.IMessageService, Views.MessageService>();

            DependencyService.Register<ViewModels.INavigationService, Views.NavigationService>();

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
       

        
