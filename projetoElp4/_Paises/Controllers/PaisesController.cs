using projetoElp4._Paises.Daos;
using projetoElp4.MainWindow.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoElp4._Paises.Controllers
{
    internal class PaisesController : Controller
    {
        protected PaisDao oPaisDao;
        public PaisesController() : base()
        {
            oPaisDao = new PaisDao();
        }
        public override string Salvar(Object obj)
        {
            return oPaisDao.Salvar(obj);
        }

        public override string Excluir(Object obj)
        {
            return oPaisDao.Excluir(obj);
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
