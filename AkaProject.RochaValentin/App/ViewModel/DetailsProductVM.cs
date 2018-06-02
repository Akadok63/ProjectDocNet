using App.ViewModel.Common;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace App.ViewModel
{
    public class DetailsProductVM
    {
        private int _code;
        private string _description;
        private int _stock;
        private int _actif;
        private RelayCommand _addOperation;


        public DetailsProductVM(Product product)
        {
            _code = product.Code;
            _description = product.Description;
            _stock = product.Stock;
            _actif = product.Actif;
        }

        public int Code
        {
            get { return _code; }
            set { _code = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public int Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }

        public int Actif
        {
            get { return _actif; }
            set { _actif = value; }
        }

        public ICommand addOperation
        {
            get
            {
                if (_addOperation == null)
                    _addOperation = new RelayCommand(() => this.ShowWindowOperation());
                return _addOperation;
            }
        }

        private void ShowWindowOperation()
        {
            View.Operation operationWindow = new View.Operation();
            operationWindow.DataContext = this;
            operationWindow.ShowDialog();
        }
    }
}
