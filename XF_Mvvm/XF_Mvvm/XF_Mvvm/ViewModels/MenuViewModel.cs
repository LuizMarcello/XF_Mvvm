using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace XF_Mvvm.ViewModels
{
    public class MenuViewModel
    {
        public ICommand RegistroCommand
        {
            get;
            private set;
        }

        private readonly INavigationService _navigationService;

        public MenuViewModel()
        {
            //Injeção de dependência:
            //_navigationService recebe agora instâncias das classes que implementam esta interface,
            //porque esta interface está registrada no serviço de dependência
            _navigationService = DependencyService.Get<INavigationService>();

            RegistroCommand = new Command(RegistroCmd);
        }

        private void RegistroCmd()
        {
            this._navigationService.NavegarParaRegistro();
        }
    }
}

        

            
           
           

       

        
