using System.Windows;
using System.Windows.Data;
using CustomContextMenuCodeBehind.Item;

namespace CustomContextMenuCodeBehind.CustomControl
{
    public class StageListBox : CustomListBox
    {
        #region Properties
        public ScreenInfo SelectedScreen
        {
            get
            {
                return (ScreenInfo)GetValue(SelectedScreenProperty);
            }
            set
            {
                SetValue(SelectedScreenProperty, value);
            }
        }
        #endregion

        #region Dependency Properties
        public static readonly DependencyProperty SelectedScreenProperty =
            DependencyProperty.Register(nameof(SelectedScreen), typeof(ScreenInfo), typeof(StageListBox), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, SelectedScreenChanged));
        #endregion

        #region Callbacks
        private static void SelectedScreenChanged(DependencyObject callerObject, DependencyPropertyChangedEventArgs e)
        {
            ((StageListBox)callerObject).ResetSelection(e.NewValue as ScreenInfo);
        }
        #endregion

        #region CTOR
        public StageListBox()
        {
            SetBinding(SelectedItemProperty, new Binding(nameof(SelectedScreen)) { Source = this });
        }
        #endregion

        #region Methods
        private void ResetSelection(ScreenInfo screenInfo)
        {
            if (Items != null && !Items.Contains(screenInfo))
                SelectedItem = null;
        }
        #endregion
    }
}
