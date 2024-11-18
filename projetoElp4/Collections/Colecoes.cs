using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoElp4.MainWindow.Collection
{
    internal class Colecoes<T> where T : Pai
    {

        protected List<T> aLista;

        public Colecoes()
        {
            aLista = new List<T>();
        }

        public virtual void Inserir(T obj)
        {
            if (Pesquisar(obj.Codigo) != -1) return;

            aLista.Add(obj);
        }
        public virtual void CarregaTudo()
        {

        }
        public virtual Object CarregaObj(int ind)
        {
            if (ind >= 0 && ind < aLista.Count)
            {
                return aLista[ind];
            }
            else 
                return null;
        }
        public virtual string Atualizar(int ind, T item)
        {
            string msg = string.Empty;
            if (ind >= 0 && ind < aLista.Count)
            {
                aLista[ind] = item;
            }
            else
                msg = "Indice fora da faixa da lista";
            return msg;
        }

        public virtual int Pesquisar(int codigo)
        {
            return aLista.FindIndex(o => o.Codigo == codigo);
        }

        public virtual bool Remover(T obj)
        {
            aLista.Remove(obj);

            return true;
        }
        public virtual void Imprimir()
        {
            foreach (var item in aLista)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public virtual void Ordenar()
        {
            aLista.Sort();
        }
        public int Tamanho()
        {
            return aLista.Count;
        }

    }
}

