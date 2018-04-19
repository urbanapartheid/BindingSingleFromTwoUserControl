using System.Windows;
using System.Windows.Controls;
using CustomContextMenuCodeBehind.Item;

namespace CustomContextMenuCodeBehind.CustomControl
{
    public class AudienceListBox : CustomListBox
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
            DependencyProperty.Register(nameof(SelectedScreen), typeof(ScreenInfo), typeof(AudienceListBox), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, SelectedScreenChanged));
        #endregion

        #region Callbacks
        private static void SelectedScreenChanged(DependencyObject callerObject, DependencyPropertyChangedEventArgs e)
        {
            ((AudienceListBox)callerObject).ResetSelection(e.NewValue as ScreenInfo);
        }

        #endregion

        #region CTOR
        public AudienceListBox()
        {
        }
        #endregion

        #region Methods
        protected override void OnSelectionChanged(SelectionChangedEventArgs e)
        {
            if (e.AddedItems != null && e.AddedItems.Count > 0)
                SelectedScreen = e.AddedItems[0] as ScreenInfo;

            base.OnSelectionChanged(e);
        }

        private void ResetSelection(ScreenInfo screenInfo)
        {
            if (Items != null && !Items.Contains(screenInfo))
                SelectedItem = null;
        }
        #endregion
    }
}
