using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpImgLgn.Models
{
    public class PersonneModel : BindableBase
    {
        private int _Id;
        public int Id
        {
            get { return _Id; }
            set { SetProperty(ref _Id, value); }
        }

        private string _Nom;
        public string Nom
        {
            get { return _Nom; }
            set { SetProperty(ref _Nom, value); }
        }

        private string _Prenom;
        public string Prenom
        {
            get { return _Prenom; }
            set { SetProperty(ref _Prenom, value); }
        }

        private int _Age;
        public int Age
        {
            get { return _Age; }
            set { SetProperty(ref _Age, value); }
        }

        private string _Login;
        public string Login
        {
            get { return _Login; }
            set { SetProperty(ref _Login, value); }
        }

        private string _Password;
        public string Password
        {
            get { return _Password; }
            set { SetProperty(ref _Password, value); }
        }
    }
}
