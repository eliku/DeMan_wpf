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
            productList.Items.Add("Hello");
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

    }

}
