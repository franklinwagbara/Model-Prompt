using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace HelloWorldWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeHelloWorldTextBlock();
            Title = "My Hello World App";
        }

        /// <summary>
        /// Initializes and adds a TextBlock to the MainGrid with predefined properties.
        /// </summary>
        private void InitializeHelloWorldTextBlock()
        {
            TextBlock helloWorldText = new TextBlock();
            helloWorldText.Text = "Hello, World!";
            helloWorldText.FontFamily = new FontFamily("Arial");
            helloWorldText.FontSize = 24;
            helloWorldText.VerticalAlignment = VerticalAlignment.Center;
            helloWorldText.HorizontalAlignment = HorizontalAlignment.Center;

            MainGrid.Children.Add(helloWorldText);
        }
    }
}