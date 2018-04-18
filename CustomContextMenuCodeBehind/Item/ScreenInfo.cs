namespace CustomContextMenuCodeBehind.Item
{
    public class ScreenInfo
    {
        #region Variables
        public string _name = string.Empty;
        public string _resolution = string.Empty;
        #endregion

        #region Properties

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (_name != value)
                {
                    _name = value;
                }
            }
        }

        public string Resolution
        {
            get
            {
                return _resolution;
            }
            set
            {
                if (_resolution != value)
                {
                    _resolution = value;
                }
            }
        }
        #endregion

        #region CTOR
        public ScreenInfo(string name, string resolution)
        {
            _name = name;
            _resolution = resolution;
        }
        #endregion
    }
}
