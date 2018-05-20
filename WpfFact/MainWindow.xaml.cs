using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfFact
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

        

       public static Task<float> Factmetod(int a)
        {
            float val = 1;
            return Task.Run(() => {
                
                for (int i = 1; i <= a; i++)
                {
                    val = val * i;
                }
                
                return val;
            });
        }


        

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = 0;
            try
            {
                a =Convert.ToInt32( Number.Text);
            }
            catch (Exception)
            {

                throw;
            }
           
            float result = await Factmetod(a);
            Res.Content = result;
        }

        
    }
}
