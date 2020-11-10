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

namespace Covid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Case_Click(object sender, RoutedEventArgs e)
        {

            WindowCase win1 = new WindowCase();
            win1.Show();
        }

        private void Button_Contact_Click(object sender, RoutedEventArgs e)
        {
            WindowConcact win2 = new WindowConcact();
            win2.Show();
        }

        

        private void Button_List_Click(object sender, RoutedEventArgs e)
        {
            WindowList win3 = new WindowList();
            win3.Show();
        }

        private void Button_Finish_Click(object sender, RoutedEventArgs e)
        {
            WindowList win3 = new WindowList();
            win3.Show();
        }
    }
}
