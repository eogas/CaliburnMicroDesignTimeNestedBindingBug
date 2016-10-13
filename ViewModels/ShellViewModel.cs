using Caliburn.Micro;

namespace CMDTNBB.ViewModels
{
    public class ShellViewModel : PropertyChangedBase, IShell
    {
        private ItemViewModel itemVM;
        public ItemViewModel ItemVM
        {
            get
            {
                return itemVM;
            }
            set
            {
                itemVM = value;
                NotifyOfPropertyChange(() => ItemVM);
            }
        }

        public ShellViewModel() : this(new ItemViewModel()) { }
        public ShellViewModel(ItemViewModel itemVM)
        {
            ItemVM = itemVM;
        }
    }
}