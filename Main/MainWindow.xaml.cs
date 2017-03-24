// Sample program demonstrating the use of the FloatingPointTextBox control.
//
//   Author: Ken Walker, Bridge360 (http://bridge360.com)

using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace FloatingPointTextBox.Main
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private float _textBoxValue = 12.34f;
        public float TextBoxValue
        {
            get { return _textBoxValue; }
            set
            {
                if (value != _textBoxValue)
                {
                    _textBoxValue = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private float _floatTextBoxValue = 56.78f;
        public float FloatTextBoxValue
        {
            get { return _floatTextBoxValue; }
            set
            {
                if (value != _floatTextBoxValue)
                {
                    _floatTextBoxValue = value;
                    NotifyPropertyChanged();
                }
            }
        }

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
