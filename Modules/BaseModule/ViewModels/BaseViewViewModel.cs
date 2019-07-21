using Prism.Mvvm;
using System.ComponentModel;

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

        private string _oldMessage;
        public string OldMessage
        {
            get { return _oldMessage; }
            set { SetProperty(ref _oldMessage, value); }
        }

        protected override void OnPropertyChanged(string propertyName)
        {
            if (propertyName == "Message")
            {
                OldMessage = Message;
            }
        }

        public BaseViewViewModel()
        {
            Message = "Click button to load modules";           
        }
    }
}
