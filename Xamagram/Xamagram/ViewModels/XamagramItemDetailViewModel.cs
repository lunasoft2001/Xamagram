using Xamagram.Models;
using Xamagram.ViewModels.Base;

namespace Xamagram.ViewModels
{
    public class XamagramItemDetailViewModel : ViewModelBase
    {
        private XamagramItem _item;

        public XamagramItem Item
        {
            get { return _item; }
            set
            {
                _item = value;
                OnPropertyChanged("Item");
            }
        }

        public override void OnAppearing(object navigationContext)
        {
            base.OnAppearing(navigationContext);

            if(navigationContext is XamagramItem)
            {
                Item = (XamagramItem)navigationContext;
            }
        }
    }
}