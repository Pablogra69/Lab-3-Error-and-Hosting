using System.Windows;
using System.ServiceModel;
using Covid.ServiceReference1;
using System;

namespace Covid
{
    /// <summary>
    /// Interaction logic for WindowCase.xaml
    /// </summary>
    public partial class WindowCase : Window
    {
        public WindowCase()
        {
            InitializeComponent();
            
        }

        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {

            Service1Client dd = new Service1Client();

            try
            {
                //dd.Open();
               
                    dd.InsertCase( new ServiceReference1.PersonCase
                    {
                        DateTest = DatePicker_Test.ToString(),
                        DateResults = DatePicker_Case.ToString(),
                        CityCase = TextBox_City.Text,
                        Name = TextBox_Name.Text,
                       

                    });

                //GetValue(dd.Add
                //       (new ComplexTest.Complex
                //       {
                //           RealValue = Convert.ToDouble(TextBlockNumerReal.Text),
                //           ImagValue = Convert.ToDouble(TextBlockNumerUnreal.Text)
                //       },
                //       new ComplexTest.Complex
                //       {
                //           RealValue = Convert.ToDouble(TextBlockNumerReal2.Text),
                //           ImagValue = Convert.ToDouble(TextBlockNumerUnreal2.Text)
                //       })).ToString() + "i)";
                
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
    }
}
