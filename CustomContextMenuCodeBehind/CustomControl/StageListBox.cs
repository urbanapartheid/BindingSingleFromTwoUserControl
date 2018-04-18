using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using CustomContextMenuCodeBehind.Item;

namespace CustomContextMenuCodeBehind.CustomControl
{
    public class StageListBox : CustomListBox
    {
        #region Properties
        public List<ScreenInfo> Screens
        {
            get
            {
                return (List<ScreenInfo>)GetValue(ScreensProperty);
            }
            set
            {
                SetValue(ScreensProperty, value);
            }
        }

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

        public static readonly DependencyProperty ScreensProperty =
            DependencyProperty.Register(nameof(Screens), typeof(List<ScreenInfo>), typeof(StageListBox), new FrameworkPropertyMetadata(null, ScreensUpdated));

        #endregion

        #region Callbacks
        private static void ScreensUpdated(DependencyObject callerObject, DependencyPropertyChangedEventArgs e)
        {
            ((StageListBox)callerObject).ReloadItemsSource(e.NewValue as List<ScreenInfo>);
        }

        private static void SelectedScreenChanged(DependencyObject callerObject, DependencyPropertyChangedEventArgs e)
        {
            ((StageListBox)callerObject).ResetSelection(e.NewValue as ScreenInfo);
        }
        #endregion


        #region CTOR
        public StageListBox()
        {

        }
        #endregion

        #region Methods
        private void ReloadItemsSource(List<ScreenInfo> list)
        {
            ItemsSource = list;
        }

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
