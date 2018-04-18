using System.Windows;
using CustomContextMenuCodeBehind.ViewModel;

namespace CustomContextMenuCodeBehind
{
    public partial class MainWindow : Window
    {
        #region CTOR
        public MainWindow()
        {
            InitializeComponent();

            SetDataContext();
        }
        #endregion

        #region Methods
        private void SetDataContext()
        {
            var testVM = new TestVM();
            DataContext = testVM;
        }
        #endregion
    }
}
