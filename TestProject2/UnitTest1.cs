using NUnit.Framework;
using HelloWorldWPF;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Media;

namespace HelloWorldWPFTests
{
    public class MainWindowTests
    {
        private MainWindow mainWindow;

        [SetUp]
        public void Setup()
        {
            // Create a new instance of the MainWindow for each test
            mainWindow = new MainWindow();
            // Simulate the window being loaded, which triggers the TextBlock initialization.
            mainWindow.Loaded += (sender, args) => { /* No action needed, initialization happens in the event handler */ };
            mainWindow.Show(); //Manually show the window, otherwise the visual tree is not built.
        }

        [TearDown]
        public void TearDown()
        {
            // Close the window after each test
            mainWindow.Close();
        }

        [Test]
        public void MainWindow_Title_IsCorrect()
        {
            Assert.That("My Hello World App", mainWindow.Title);
        }

        [Test]
        public void HelloWorldTextBlock_Exists()
        {
            TextBlock helloWorldTextBlock = mainWindow.FindName("HelloWorldTextBlock") as TextBlock;
            Assert.IsNotNull(helloWorldTextBlock, "TextBlock 'HelloWorldTextBlock' not found.");
        }


        [Test]
        public void HelloWorldTextBlock_Text_IsCorrect()
        {
            TextBlock helloWorldTextBlock = mainWindow.FindName("HelloWorldTextBlock") as TextBlock;
            Assert.That("Hello, World!", helloWorldTextBlock.Text);
        }

        [Test]
        public void HelloWorldTextBlock_FontFamily_IsCorrect()
        {
            TextBlock helloWorldTextBlock = mainWindow.FindName("HelloWorldTextBlock") as TextBlock;
            Assert.That("Arial", helloWorldTextBlock.FontFamily.Source);
        }

        [Test]
        public void HelloWorldTextBlock_FontSize_IsCorrect()
        {
            TextBlock helloWorldTextBlock = mainWindow.FindName("HelloWorldTextBlock") as TextBlock;
            Assert.That(24, helloWorldTextBlock.FontSize);
        }

        [Test]
        public void HelloWorldTextBlock_HorizontalAlignment_IsCorrect()
        {
            TextBlock helloWorldTextBlock = mainWindow.FindName("HelloWorldTextBlock") as TextBlock;
            Assert.That(HorizontalAlignment.Center, helloWorldTextBlock.HorizontalAlignment);
        }

        [Test]
        public void HelloWorldTextBlock_VerticalAlignment_IsCorrect()
        {
            TextBlock helloWorldTextBlock = mainWindow.FindName("HelloWorldTextBlock") as TextBlock;
            Assert.That(VerticalAlignment.Center, helloWorldTextBlock.VerticalAlignment);
        }
    }
}