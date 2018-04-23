using DevExpress.Mvvm;
using System.Windows.Input;

namespace Example.ViewModel {
    public class MainViewModel {
        protected virtual IMessageBoxService MessageBoxService { get { return null; } }
        public void ShowMessage() {
            MessageBoxService.Show("This is MainView!");
        }
    }
}
