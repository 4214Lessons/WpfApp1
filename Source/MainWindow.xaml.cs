using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Source;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();



        // Background = new SolidColorBrush(Color.FromRgb(100, 100, 100))
        // Background = Brushes.Violet

        Button button = new()
        {
            Content = "Click me",
            Background = new SolidColorBrush(Colors.DeepSkyBlue),
            FontSize = 42,
            Cursor = Cursors.Hand
        };

        Grid.SetColumn(button, 1);
        Grid.SetRow(button, 1);

        button.Click += Button_Click;


        container.Children.Add(button);


        // WindowState = WindowState.Minimized;
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
       MessageBoxResult result =  MessageBox.Show("Button_Click","caption", MessageBoxButton.OKCancel, MessageBoxImage.Information);
    }
}
