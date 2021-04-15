using Projeto_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_2.Classes
{
    class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> lista = new List<Serie>();
        public void Atualiza(int id, Serie serie)
        {
            lista[id] = serie;
        }

        public void Exclui(int id)
        {
            lista[id].setExcluir(true);
        }

        public void Insere(Serie serie)
        {
            lista.Add(serie);
        }

        public List<Serie> Lista()
        {
            return lista;
        }

        public int ProximoId()
        {
            return lista.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return lista[id];
        }
    }
}
