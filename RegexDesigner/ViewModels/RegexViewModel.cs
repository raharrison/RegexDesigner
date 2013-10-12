using System.ComponentModel;
using System.Runtime.CompilerServices;
using RegexDesigner.Annotations;

namespace RegexDesigner.ViewModels
{
    class RegexViewModel : INotifyPropertyChanged
    {
        public RegexViewModel()
        {
            InputText = "Some default input text";
            Global = true;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        private string inputText;

        public string InputText
        {
            get { return inputText; }
            set
            {
                if (inputText == value) return;
                inputText = value;
                OnPropertyChanged();
            }
        }

        private bool global;

        public bool Global
        {
            get { return global; }
            set
            {
                if (global == value) return;
                global = value;
                OnPropertyChanged();
            }
        }
    }
}
