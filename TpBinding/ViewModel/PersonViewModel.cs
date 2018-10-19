using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpBinding.Models;

namespace TpBinding.ViewModel

{
    public class PersonViewModel : BindableBase

    {
        private DelegateCommand _DemoCommand;
        public DelegateCommand DemoCommand
        {
            get { return _DemoCommand; }
        }

        private PersonModel _PersonModelData;
        public PersonModel PersonModelData //dans cette propriété public nous modifions les attributs de celle qui est privée
        {
            get { return _PersonModelData; }
            set { SetProperty(ref _PersonModelData, value); }
        }

        public PersonViewModel() //utiliser le raccourci "ctor"+ tab tab
        {
            _PersonModelData = new PersonModel();
            _PersonModelData.Name = "Oualim";
            _PersonModelData.LastName = "NAIMI";
            _PersonModelData.Age = 35;
            
            _DemoCommand = new DelegateCommand(DoAction, canDoAction);
        }

        private bool canDoAction()
        {
            return true;
        }

       
        private void DoAction()
        {
            this.PersonModelData.Name = "Benjamin Bittane";
            
        }
    }
}
