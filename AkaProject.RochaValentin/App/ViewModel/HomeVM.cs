using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.ViewModel
{
    public class HomeVM : BaseVM
    {
        private ListProductVM _listProductVM = null;

        public HomeVM()
        {
            _listProductVM = new ListProductVM();
        }

        public ListProductVM ListProductVM
        {
            get { return _listProductVM; }
            set { _listProductVM = value; }
        }
    }
}
