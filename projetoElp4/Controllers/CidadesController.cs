using projetoElp4._Cidades.Daos;
using projetoElp4._Estados.Daos;
using projetoElp4.MainWindow.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoElp4._Cidades.Controllers
{
    internal class CidadesController : Controller
    {
        protected CidadesDao aCidadeDao;
        public CidadesController() : base()
        {
            aCidadeDao = new CidadesDao();
        }
        public override string Salvar(Object obj)
        {
            return aCidadeDao.Salvar(obj);
        }

        public override string Excluir(Object obj)
        {
            return aCidadeDao.Excluir(obj);
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
