using Caliburn.Micro;

namespace CMDTNBB.ViewModels
{
    public class ItemViewModel : PropertyChangedBase
    {
        private string message;
        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
                NotifyOfPropertyChange(() => Message);
            }
        }

        private ChildItemViewModel childViewModel;
        public ChildItemViewModel ChildVM
        {
            get
            {
                return childViewModel;
            }
            set
            {
                childViewModel = value;
                NotifyOfPropertyChange(() => ChildVM);
            }
        }

        public ItemViewModel() : this(new ChildItemViewModel()) { }
        public ItemViewModel(ChildItemViewModel childVM)
        {
            ChildVM = childVM;
            Message = "Hello world!";
        }
    }
}