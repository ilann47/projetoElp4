﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoElp4.MainWindow.Controller
{
    public abstract class Controller
    {
        public abstract string Salvar(Object obj);

        public abstract string Excluir(Object obj);

        public abstract Object CarregaTudo();

        public abstract Object CarregaObj(int IdObj);

    }
}
