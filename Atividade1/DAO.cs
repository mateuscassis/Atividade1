using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
    internal interface DAO<T>
    {     
        void cadastrarUsuario(T t);

        void updateUsuario(T t);

        List<T> viewUsuario();

        void deletarUsuario(T t);
    }
}
