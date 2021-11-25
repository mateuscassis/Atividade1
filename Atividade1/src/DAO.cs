using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
    internal interface DAO
    {     
        void cadastrarUsuario(Usuario usuario);

        void updateUsuario(Usuario usuario);

        List<Usuario> viewUsuario();

        void deletarUsuario(Usuario usuario);
    }
}
