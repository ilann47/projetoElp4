using projetoElp4._Estados.Daos;
using projetoElp4.MainWindow.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoElp4._Estados.Controllers
{
    internal class EstadosController : Controller
    {
        protected EstadosDao oEstadoDao;
        public EstadosController() : base()
        {
            oEstadoDao = new EstadosDao();
        }
        public override string Salvar(Object obj)
        {
            return oEstadoDao.Salvar(obj);
        }

        public override string Excluir(Object obj)
        {
            return oEstadoDao.Excluir(obj);
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
