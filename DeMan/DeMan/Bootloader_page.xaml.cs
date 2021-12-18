using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
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
    /// Interaction logic for Bootloader_page.xaml
    /// </summary>
    public partial class Bootloader_page : Page
    {
        public Bootloader_page()
        {
            InitializeComponent();

        }

        private void btnWriteBoot_Click(object sender, RoutedEventArgs e)
        {
            Duration duration = new Duration(TimeSpan.FromSeconds(20));
            DoubleAnimation doubleanimation = new DoubleAnimation(200.0, duration);
            PBar.BeginAnimation(ProgressBar.ValueProperty, doubleanimation);
        }
    }
}
