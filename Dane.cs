using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NET_INIS4_PR2._2_z2
{
    public class Dane : INotifyPropertyChanged
    {
        string imię = "Przemek";
        public string Imię
        {
            get { return imię; }
            set
            {
                imię = value;
                OnPropertyChanged();
                OnPropertyChanged("Format");
            }
        }
        public string Format {
            get {
                return $"Podane imię to {Imię}.";
            } 
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
