using System.Collections.Generic;
using System.ComponentModel;
using CustomContextMenuCodeBehind.Item;

namespace CustomContextMenuCodeBehind.ViewModel
{
    public class TestVM
    {
        #region Variables
        private ScreenInfo _selectedScreen;
        private List<ScreenInfo> _audienceScreenCollection;
        private List<ScreenInfo> _stageScreenCollection;
        #endregion

        #region Properties
        public ScreenInfo SelectedScreen
        {
            get
            {
                return _selectedScreen;
            }
            set
            {
                if (_selectedScreen != value)
                {
                    _selectedScreen = value;
                    OnPropertyChanged(nameof(SelectedScreen));
                }
            }
        }

        public List<ScreenInfo> AudienceScreenCollection => _audienceScreenCollection;

        public List<ScreenInfo> StageScreenCollection => _stageScreenCollection;
        #endregion

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region CTOR
        public TestVM()
        {
            _audienceScreenCollection = new List<ScreenInfo>();
            _audienceScreenCollection.Add(new ScreenInfo("Screen 1", "1920 X 1080"));
            _audienceScreenCollection.Add(new ScreenInfo("Screen 2", "1920 X 1080"));
            _audienceScreenCollection.Add(new ScreenInfo("Screen 3", "1920 X 1080"));
            _audienceScreenCollection.Add(new ScreenInfo("Screen 4", "1920 X 1080"));

            _stageScreenCollection = new List<ScreenInfo>();
            _stageScreenCollection.Add(new ScreenInfo("Stage Display 1", "1920 X 1080"));
            _stageScreenCollection.Add(new ScreenInfo("Stage Display 2", "1920 X 1080"));
            _stageScreenCollection.Add(new ScreenInfo("Stage Display 3", "1920 X 1080"));
            _stageScreenCollection.Add(new ScreenInfo("Stage Display 4", "1920 X 1080"));
        }
        #endregion

        #region Methods

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
