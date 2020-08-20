using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace XF_Mvvm.ViewModels
{
    public interface INavigationService
    {
        Task NavegarParaLogin();
        Task NavegarParaMenu();
        Task NavegarParaRegistro();
    }
}
