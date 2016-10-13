
using Caliburn.Micro;

namespace CMDTNBB.ViewModels
{
    public class ChildItemViewModel : PropertyChangedBase
    {
        private string childMessage;
        public string ChildMessage
        {
            get
            {
                return childMessage;
            }
            set
            {
                childMessage = value;
                NotifyOfPropertyChange(() => ChildMessage);
            }
        }

        public ChildItemViewModel()
        {
            ChildMessage = "Goodbye world!";
        }
    }
}
