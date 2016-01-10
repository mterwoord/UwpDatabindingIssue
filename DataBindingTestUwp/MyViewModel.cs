using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.UI.Xaml;

namespace DataBindingTestUwp
{
    public class MyViewModel: DependencyObject
    {
        public static readonly DependencyProperty MessageProperty = DependencyProperty.Register("Message", typeof(string), typeof(MyViewModel), new PropertyMetadata(""));

        public string Message
        {
            get
            {
                return (string)GetValue(MessageProperty);
            }
            set
            {
                SetValue(MessageProperty, value);
            }
        }

        public void SetMessage(string message)
        {
            Message = message;
        }
    }
}
