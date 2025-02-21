using System;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using NUnit.Framework;

namespace HelloWorldWPF.Tests
{
    [TestFixture, Apartment(ApartmentState.STA)]
    public class MainWindowTests
    {
        private MainWindow mainWindow;

        [SetUp]
        public void Setup()
        {
            // Create a new MainWindow instance before each test
            mainWindow = new MainWindow();
        }

        [TearDown]
        public void TearDown()
        {
            // Close the window after each test to release resources
            if (mainWindow != null)
            {
                mainWindow.Close();
                mainWindow = null;
            }
        }

        [Test]
        public void MainWindow_TitleIsCorrect()
        {
            Assert.That(mainWindow.Title, Is.EqualTo("My Hello World App"));
        }

        [Test]
        public void MainWindow_TextBlockExists()
        {
            // Access the Content of the Window which should be the Grid
            if (mainWindow.Content is Grid mainGrid)
            {
                // Check if the Grid has children
                Assert.That(mainGrid.Children.Count, Is.GreaterThan(0), "The MainGrid should have at least one child (the TextBlock).");

                // Check if the first child is a TextBlock
                Assert.That(mainGrid.Children[0], Is.TypeOf<TextBlock>(), "The first child of MainGrid should be a TextBlock.");
            }
            else
            {
                Assert.Fail("The Content of the MainWindow is not a Grid.");
            }
        }

        [Test]
        public void MainWindow_TextBlockPropertiesAreCorrect()
        {
            // Access the Content of the Window which should be the Grid
            if (mainWindow.Content is Grid mainGrid)
            {
                // Ensure that mainGrid has children
                Assert.That(mainGrid.Children.Count, Is.GreaterThan(0), "The MainGrid should have at least one child (the TextBlock).");

                // Assuming the TextBlock is the first child of the Grid
                if (mainGrid.Children[0] is TextBlock textBlock)
                {
                    Assert.That(textBlock.Text, Is.EqualTo("Hello, World!"));
                    Assert.That(textBlock.FontFamily, Is.EqualTo(new FontFamily("Arial")));
                    Assert.That(textBlock.FontSize, Is.EqualTo(24));
                    Assert.That(textBlock.VerticalAlignment, Is.EqualTo(VerticalAlignment.Center));
                    Assert.That(textBlock.HorizontalAlignment, Is.EqualTo(HorizontalAlignment.Center));
                }
                else
                {
                    Assert.Fail("The first child of MainGrid is not a TextBlock.");
                }
            }
            else
            {
                Assert.Fail("The Content of the MainWindow is not a Grid.");
            }
        }
    }
}