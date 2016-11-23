using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.ViewModels
{
    class TemplateViewModel : INotifyPropertyChanged
    {
        public TemplateViewModel()
        {
            this._buttonText = "ThisCameFromTheViewModel";
            this._input = String.Empty;
        }

        private string _buttonText;

        public string ButtonText
        {
            get
            {
                return _buttonText;
            }
            set
            {
                _buttonText = value;
                OnPropertyChanged("ButtonText");
            }
        }


        private string _input;
        public string Input
        {
            get
            {
                return _input;
            }
            set { _input = value; OnPropertyChanged("Input"); }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
