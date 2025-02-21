// MainWindow.xaml.cs
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace HelloWorldWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeHelloWorldTextBlock();
            Title = "My Hello World App";
        }

        private void InitializeHelloWorldTextBlock()
        {
            TextBlock helloWorldTextBlock = new TextBlock();
            helloWorldTextBlock.Text = "Hello, World!";
            helloWorldTextBlock.FontFamily = new FontFamily("Arial");
            helloWorldTextBlock.FontSize = 24;
            helloWorldTextBlock.HorizontalAlignment = HorizontalAlignment.Center;
            helloWorldTextBlock.VerticalAlignment = VerticalAlignment.Center;

            MainGrid.Children.Add(helloWorldTextBlock);
        }
    }
}