using System.Windows.Input;
using Xamarin.Forms;
using XF_Mvvm.Model;

namespace XF_Mvvm.ViewModels
{
    public class LoginViewModel : Usuario
    {
        public ICommand LoginCommand
        {
            get;
            private set;
        }

        public ICommand RegistroCommand
        {
            get;
            private set;
        }

        public ICommand ResetarCommand
        {
            get;
            private set;
        }

        private readonly IMessageService _messageService;
        private readonly INavigationService _navigationService;

        public LoginViewModel()
        {
            //_messageService vai receber uma instância da classe que implementou esta interface,
            //porque a interface está registrada no serviço de dependência
            _messageService = DependencyService.Get<IMessageService>();

            //_navigationService vai receber uma instância da classe que implementou esta interface,
            //porque a interface está registrada no serviço de dependência
            _navigationService = DependencyService.Get<INavigationService>();

            LoginCommand = new Command(LoginCmd);
            RegistroCommand = new Command(RegistroCmd);
            ResetarCommand = new Command(ResetarCmd);
        }

        private void LoginCmd()
        {
            if (this.Nome == "macoratti" && this.Senha == "123")
            {
                _navigationService.NavegarParaMenu();
            }
            else
            {
                _messageService.ExibirMensagemAsync("Nome do usuário ou senha inválidos");
            }
        }

        private void RegistroCmd()
        {
            this._navigationService.NavegarParaRegistro();
        }

        private void ResetarCmd()
        {
            this.Nome = null;
            this.Senha = null;
        }
    }
}

        

