using System.Windows;
using System.ServiceModel;
using Covid.ServiceReference1;
using System;

namespace Covid
{
    /// <summary>
    /// Interaction logic for WindowList.xaml
    /// </summary>
    public partial class WindowList : Window
    {
        public WindowList()
        {
            InitializeComponent();
            Service1Client dd = new Service1Client();

            try
            {
                //dd.Open();

                DataGrid_List.ItemsSource = dd.GetAllPerson();

              

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
            
        }
    }
}
