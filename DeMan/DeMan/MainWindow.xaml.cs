using System;
using System.Collections.Generic;
using System.Data;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace DeMan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            productGrid.Items.Add(new DataTableProduct { idType = 34, Address = 0, Name = "Binar 10D" });
            AllPanel.Content = new DeMan.MainPage();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void GridBarTitul_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            imgIcon.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
            NameProduct.Visibility = Visibility.Visible;
        }
         private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
         {
             imgIcon.Visibility = Visibility.Collapsed;
             ButtonOpenMenu.Visibility = Visibility.Visible;
             ButtonCloseMenu.Visibility = Visibility.Collapsed;
             NameProduct.Visibility = Visibility.Collapsed;
        }

        private void Boot_Click(object sender, RoutedEventArgs e)
        {
            AllPanel.Content = new DeMan.Bootloader_page();
        }
        private void MenuLight_Click(object sender, RoutedEventArgs e)
        {
            Brush[] brushes = typeof(Brushes).GetProperties().Select(p => (Brush)p.GetValue(null)).ToArray();
            Random r = new Random();
            var b = brushes[r.Next(brushes.Length)];
            Application.Current.Resources["solidGrayBrush"] = new SolidColorBrush(Color.FromArgb(0xFF, 0x40, 0x56, 0x8D));
            Application.Current.Resources["solidHeaderBrush"] = new SolidColorBrush(Color.FromArgb(0xFF, 0xCC, 0xD5, 0xF0));
            Application.Current.Resources["solidTextBrush"] = new SolidColorBrush(Color.FromArgb(0xFF, 0x00, 0x00, 0x00)); 
            Application.Current.Resources["solidPanelBrush"] = new SolidColorBrush(Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF)); //#FFCCD5F0
        }

        private void MenuDark_Click(object sender, RoutedEventArgs e)
        {
            Brush[] brushes = typeof(Brushes).GetProperties().Select(p => (Brush)p.GetValue(null)).ToArray();
            Random r = new Random();
            var b = brushes[r.Next(brushes.Length)];
            Application.Current.Resources["solidGrayBrush"] = new SolidColorBrush(Color.FromArgb(0xFF, 0x2D, 0x2D, 0x30));
            Application.Current.Resources["solidHeaderBrush"] = new SolidColorBrush(Color.FromArgb(0xFF, 0x2D, 0x2D, 0x30));
            Application.Current.Resources["solidTextBrush"] = new SolidColorBrush(Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF)); 
            Application.Current.Resources["solidPanelBrush"] = new SolidColorBrush(Color.FromArgb(0xFF, 0x00, 0x00, 0x00));
        }
    }

}
