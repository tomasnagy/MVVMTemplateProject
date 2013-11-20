using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMVVM.ViewModel
{
    class Temp1VM : ObservableObject,IPage
    {
        public string Name
        {
            get { return "Temp1"; }
        }
    }
}
