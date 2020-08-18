using System.Threading.Tasks;
using XF_Mvvm.ViewModels;

namespace XF_Mvvm.Views
{
    public class MessageService : IMessageService
    {
        public async Task ExibirMensagemAsync(string mensagem)
        {
            await App.Current.MainPage.DisplayAlert("Login", mensagem, "OK");

        }
    }
}
