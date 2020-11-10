using Covid.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Covid
{
    /// <summary>
    /// Interaction logic for WindowConcact.xaml
    /// </summary>
    public partial class WindowConcact : Window
    {
        public WindowConcact()
        {
            InitializeComponent();
            list();
            
        }

        Service1Client dd = new Service1Client();
        int id;
        public void list()
        {
            try
            {
                ListBox_List.ItemsSource = dd.GetAllPerson();
            }
            catch (FaultException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        
        
        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //dd.Open();

                dd.AddConcact(new ServiceReference1.PersonCase
                {
                    ID = id,
                    DateConcact = DatePicker_Contact.ToString(),
                    
                    CityConcact = TextBox_City.Text.ToString()
                });

                

            }
            catch (FaultException ex)
            {
                MessageBox.Show(ex.Message);
                // dd.Abort();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //dd.Abort();
            }
            this.Close();
        }

        private void ListBox_List_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PersonCase p = (PersonCase)ListBox_List.SelectedItem;
            id = p.ID;
            
        }
    }
}
