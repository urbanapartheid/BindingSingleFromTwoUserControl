using System.Windows.Controls;
using System.Windows.Input;

namespace CustomContextMenuCodeBehind.CustomControl
{
    public partial class CustomListBox : ListBox
    {
        #region CTOR
        public CustomListBox()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        protected override void OnPreviewMouseRightButtonDown(MouseButtonEventArgs e)
        {
            e.Handled = true;
        }
        #endregion
    }
}
