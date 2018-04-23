using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;

namespace Example.ViewModel {
    public class ChildViewModel {
        [ServiceProperty(SearchMode=ServiceSearchMode.PreferParents)]
        protected virtual IMessageBoxService MessageBoxService { get { return null; } }
        public void ShowMessage() {
            MessageBoxService.Show("This is ChildView");
        }
    }
}
