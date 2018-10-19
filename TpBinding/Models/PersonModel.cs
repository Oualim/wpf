using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpBinding.Models
{
    public class PersonModel : BindableBase
    {
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { SetProperty(ref _Name, value); }
        }

        private string _LastName;
        public string LastName
        {
            get { return _LastName; }
            set { SetProperty(ref _LastName, value); }
        }

        private int _Age;
        public int Age
        {
            get { return _Age; }
            set { SetProperty(ref _Age, value); }
        }

        private string _Nom;
        public string Nom
        {
            get { return _Nom; }
            set { SetProperty(ref _Nom, value); }
        }


    }
}
