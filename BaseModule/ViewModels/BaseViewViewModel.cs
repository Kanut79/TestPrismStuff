using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BaseModule.ViewModels
{
    public class BaseViewViewModel : BindableBase
    {
        private string _message;
                public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public BaseViewViewModel()
        {
            Message = "Click button to load modules";
        }
    }
}
