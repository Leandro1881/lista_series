using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_2.Interfaces
{
    interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);
        void Insere(T serie);
        void Exclui(int id);
        void Atualiza(int id, T serie);
        int ProximoId();
    }
}
