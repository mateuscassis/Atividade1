using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;


namespace Atividade1
{
    public class MainWindowsVM
    {
        public ICommand adicionar{get; private set;}

        public ObservableCollection<Usuario> usuarios { get; set; }
        public string TextBox_TextChanged { get; set; }
        public int TextBox_TextChanged_1 { get; set; }


        public MainWindowsVM()
        {
            usuarios = new ObservableCollection<Usuario>();

            adicionar = new RelayCommand((object obj) => {
                Usuario usuario = new Usuario(TextBox_TextChanged, TextBox_TextChanged_1);
                usuarios.Add(usuario);
            });
        }

    }
}