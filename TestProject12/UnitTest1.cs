using NUnit.Framework;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace HelloWorldWPF.Tests
{
    [TestFixture]
    [Apartment(ApartmentState.STA)]
    public class MainWindowTests
    {
        private MainWindow _mainWindow;

        [SetUp]
        public void Setup()
        {
            _mainWindow = new MainWindow();
        }

        [TearDown]
        public void TearDown()
        {
            // Ensure the window is closed after each test to release resources
            if (_mainWindow != null)
            {
                _mainWindow.Dispatcher.InvokeShutdown();
                _mainWindow = null;
            }
        }

        [Test]
        public void MainWindow_Title_IsCorrect()
        {
            Assert.That(_mainWindow.Title, Is.EqualTo("My Hello World App"));
        }

        [Test]
        public void MainWindow_TextBlock_Exists()
        {
            Grid mainGrid = (Grid)_mainWindow.Content;
            TextBlock helloWorldTextBlock = null;

            // Iterate through the children of the MainGrid to find the TextBlock
            foreach (UIElement child in mainGrid.Children)
            {
                if (child is TextBlock)
                {
                    helloWorldTextBlock = (TextBlock)child;
                    break;
                }
            }

            Assert.That(helloWorldTextBlock, Is.Not.Null, "TextBlock should exist in MainGrid");
        }

        [Test]
        public void MainWindow_TextBlock_PropertiesAreCorrect()
        {
            Grid mainGrid = (Grid)_mainWindow.Content;
            TextBlock helloWorldTextBlock = null;

            // Iterate through the children of the MainGrid to find the TextBlock
            foreach (UIElement child in mainGrid.Children)
            {
                if (child is TextBlock)
                {
                    helloWorldTextBlock = (TextBlock)child;
                    break;
                }
            }

            Assert.That(helloWorldTextBlock.Text, Is.EqualTo("Hello, World!"));
            Assert.That(helloWorldTextBlock.FontFamily.Source, Is.EqualTo("Arial"));
            Assert.That(helloWorldTextBlock.FontSize, Is.EqualTo(24));
            Assert.That(helloWorldTextBlock.HorizontalAlignment, Is.EqualTo(HorizontalAlignment.Center));
            Assert.That(helloWorldTextBlock.VerticalAlignment, Is.EqualTo(VerticalAlignment.Center));
        }
    }
}