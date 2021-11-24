using GetFood_App.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetFood_App.Modelo
{
    public class Controle
    {
        public bool tem;
        public String menssagem = "";
        public bool Acessar(String email, String senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.VerificarLogin(email, senha);
            if (!loginDao.menssagem.Equals(""))
            {
                this.menssagem = loginDao.menssagem;
            }
            return tem;

        }
        public String Cadastrar(String email, String senha, String confSenha)
        {

            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.menssagem = loginDao.Cadastrar(email, senha, confSenha);
            if (loginDao.tem)
            {
                this.tem = true;
            }
            return menssagem;
        }

        public string CadastrarAlimentos(string id, string alimento, string quantidade, string dataFabricacao, string dataVencimento)
        {

            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.menssagem = loginDao.CadastrarAlimentos(id, alimento, quantidade, dataFabricacao, dataVencimento);
            if (loginDao.tem)
            {
                this.tem = true;
            }
            return menssagem;
        }

    }
}
