using System;
using System.Collections.Generic;
using System.Text;

namespace XF_Mvvm.Model
{
    //Usei o snnipet "propfull" para criar estas "property"
    //e seus respectivos "Backing fields".
    public class Usuario : NotifyBase
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set
            {
                nome = value;
                Notificar();
            }
        }

        private string senha;

        public string Senha
        {
            get { return senha; }
            set
            {
                senha = value;
                Notificar();
            }
        }
    }
}

        


