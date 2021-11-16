using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Atividade1
{
    internal class UpdateVM
    {
        public string nomeUpdate { get; set; }
        public float cpfUpdate { get; set; }
        public ICommand botaoUpdate { get; private set; }
        public UpdateVM() 
        {
            botaoUpdate = new RelayCommand((object obj) =>
            {
                
            });
        }

    }
}
