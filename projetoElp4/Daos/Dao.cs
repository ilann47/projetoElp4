﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoElp4.MainWindow.Dao
{

    public abstract class Dao
    {
        protected SqlConnection cnn;

        public Dao() 
        {
            cnn = Banco.Abrir();
        }


        public abstract string Salvar(Object obj);

        public abstract string Excluir(Object obj);

        public abstract Object CarregaTudo();

        public abstract Object CarregaObj(int IdObj);

    }
}
