using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM
{
    class MainWindowVM : INotifyPropertyChanged
    {
        public ObservableCollection<CLIENTE> ListaClientes;
        
        public Tema6Entities BD = new Tema6Entities();

        public MainWindowVM() {
            BD.CLIENTES.Load();
            ListaClientes = new ObservableCollection<CLIENTE>(BD.CLIENTES.Local);
        }

        public void Modificar() {

            BD.SaveChanges();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
