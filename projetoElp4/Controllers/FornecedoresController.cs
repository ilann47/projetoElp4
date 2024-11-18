using projetoElp4._Estados.Daos;
using projetoElp4._Fornecedores.Daos;
using projetoElp4.MainWindow.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoElp4._Fornecedores.Controllers
{
    internal class FornecedoresController : Controller
    {
        protected FornecedoresDao oFornecedorDao;
        public FornecedoresController() : base()
        {
            oFornecedorDao = new FornecedoresDao();
        }

        public override string Salvar(Object obj)
        {
            return oFornecedorDao.Salvar(obj);
        }

        public override string Excluir(Object obj)
        {
            return oFornecedorDao.Excluir(obj);
        }

        public override Object CarregaTudo()
        {
            throw new NotImplementedException();
        }

        public override Object CarregaObj(int IdObj)
        {
            throw new NotImplementedException();

        }
    }
}
