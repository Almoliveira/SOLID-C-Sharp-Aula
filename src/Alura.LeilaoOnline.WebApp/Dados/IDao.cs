using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alura.LeilaoOnline.WebApp.Dados
{
    public interface IDao<T>
    {

        IEnumerable<T> BuscarTodos();

        T BuscarPorId(int id);

        void Incluir(T obj);

        void Alterar(T obj);

        void Excluir(T obj);
    }
}
