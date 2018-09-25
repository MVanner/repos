using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mvvm.Models;

namespace mvvm.ViewModels
{ 
    public sealed class MainViewModel
    {
        static readonly MainViewModel _instance = new MainViewModel();
        public Person ImportantPerson { get; set; }
        private MainViewModel()
        {
            ImportantPerson = DataManager.Instance.ImportantPerson;
        }
        public static MainViewModel Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
