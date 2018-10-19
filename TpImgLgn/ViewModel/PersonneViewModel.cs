using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpImgLgn.Models;

namespace TpImgLgn.ViewModel
{
    class PersonneViewModel : BindableBase
    {
        private DelegateCommand _DemoCommand;
        public DelegateCommand DemoCommand
        {
            get { return _DemoCommand; }
        }


        private PersonneModel _PersonneModelData;

        public PersonneModel PersonneModelData //dans cette propriété public nous modifions les attributs de celle qui est privée
        {
            get { return _PersonneModelData; }
            set { SetProperty(ref _PersonneModelData, value); }
        }

        public PersonneViewModel() //utiliser le raccourci "ctor"+ tab tab
        {
            _PersonneModelData = new PersonneModel();
            _PersonneModelData.Id = 0;
            _PersonneModelData.Prenom = "Oualim";
            _PersonneModelData.Nom = "NAIMI";
            _PersonneModelData.Age = 35;
            _PersonneModelData.Password = "";

            _DemoCommand = new DelegateCommand(DoAction, canDoAction);

        }

        private bool canDoAction()
        {
            return true;
        }


        private void DoAction()
        {
            

        }
    }
}
