using System.Threading.Tasks;

namespace XF_Mvvm.ViewModels
{
    public interface IMessageService
    {
        Task ExibirMensagemAsync(string mensagem);
    }
}
