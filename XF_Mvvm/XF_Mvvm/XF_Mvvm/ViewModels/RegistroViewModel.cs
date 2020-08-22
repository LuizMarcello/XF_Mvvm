using System;
using System.Collections.Generic;
using System.Text;
using XF_Mvvm.Model;
using System.Windows.Input;
using Xamarin.Forms;

namespace XF_Mvvm.ViewModels
{
    public class RegistroViewModel : Usuario
    {
        public ICommand LoginCommand
        {
            get;
            private set;
        }

        public ICommand ResetarCommand
        {
            get;
            private set;
        }

        private readonly INavigationService _navigationService;

        public RegistroViewModel()
        {
            //_nagivationService vai receber agora instâncias das classes que implementarem esta interface,
            //porque a interface está registrada no serviço de dependência
            _navigationService = DependencyService.Get<INavigationService>();

            //Criando instância:
            LoginCommand = new Command(LoginCmd);
            //Criando instância:
            ResetarCommand = new Command(ResetarCmd);
        }

       private void LoginCmd()
        {
            this._navigationService.NavegarParaLogin();
        }

        private void ResetarCmd()
        {
            this.Nome = null;
            this.Senha = null;
        }
    }
}

        

       
           

        


   
            
