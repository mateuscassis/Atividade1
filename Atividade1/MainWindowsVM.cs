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
        public ICommand abrirUpdate { get; private set; }
        public ICommand remover { get; private set; }

        public ObservableCollection<Usuario> usuarios { get; set; }
        public string TextBox_TextChanged { get; set; }
        public string TextBox_TextChanged_1 { get; set; }
        public Usuario usuarioSelecionado { get; set; }


        
        public MainWindowsVM()
        {
            usuarios = new ObservableCollection<Usuario>();

            adicionar = new RelayCommand((object obj) => {
                Usuario usuario = new Usuario(TextBox_TextChanged, TextBox_TextChanged_1);
                CadastroUsuarioBd cad = new CadastroUsuarioBd(usuario);
                usuarios.Add(usuario);
            });

            remover = new RelayCommand((object obj) => 
            {
                DeletarUsuarioBd del = new DeletarUsuarioBd(usuarioSelecionado);
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
                        UpdateUsuarioBd up = new UpdateUsuarioBd(usuarioSelecionado);
                        update.Close();     
                    });

                    update.Show();
                    
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("Usuário não selecionado!");
                }
            });  
            
        }

    }
}