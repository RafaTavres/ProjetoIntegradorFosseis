using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrador
{
    public class Controle
    {
        public bool tem;
        public string mensagem = "";

        public bool Acessar(string NomeTxt, string CpfTxt, string SenhaTxt)
        {
            LoginUsuario lg = new LoginUsuario();
            tem = lg.VerificarLogin(NomeTxt, CpfTxt, SenhaTxt);
            //if (!lg.mensagem.Equals(""))
            {
                this.mensagem = lg.mensagem;
            }
            return tem;
        }


    }
}
