using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;


namespace Atividade1
{
    public class MainWindowsVM
    {

        public ICommand adicionar{get; private set;}
        public ICommand abrirUpdate { get; private set; }
        public ICommand remover { get; private set; }
        public ObservableCollection<Usuario> usuarios { get; set; }
        public string TextBox_TextChanged { get; set; }
        public string TextBox_TextChanged_1 { get; set; }
        public Usuario usuarioSelecionado { get; set; }

        private DAO<Usuario> cad;
 
        public MainWindowsVM()
        {
            cad = new ConexaoBd();
            usuarios = new ObservableCollection<Usuario>(cad.viewUsuario());
            meusComandos();                 
        }

        private void meusComandos() {
            adicionar = new RelayCommand((object obj) => {

                    Usuario usuario = new Usuario(TextBox_TextChanged, TextBox_TextChanged_1);
                    cad.cadastrarUsuario(usuario);
                    usuarios.Add(usuario);
            });

            remover = new RelayCommand((object obj) =>
            {
                cad.deletarUsuario(usuarioSelecionado);
                usuarios.Remove(usuarioSelecionado);
            }, canObj => usuarioSelecionado != null);

            abrirUpdate = new RelayCommand((object obj) =>
            {
                try
                {
                    if (usuarioSelecionado == null)
                        throw new NullReferenceException();
                    Update update = new Update();
                    update.DataContext = usuarioSelecionado;
                    usuarioSelecionado.botaoUpdate = new RelayCommand((object param) =>
                    {
                        cad.updateUsuario(usuarioSelecionado);
                        update.Close();
                    });

                    update.Show();

                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Usuário não selecionado");
                }
            });
        }
    }
}