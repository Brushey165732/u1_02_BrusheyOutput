/* u1_02_BrusheyOutput
 * Jonathan Brushey
 * 02/08/2018
 * Takes an input of a name, and an age, then outputs a greeting, and the person's information. */

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

namespace u1_02_BrusheyOutput
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int x;
        public int age_i = 0;
        public MainWindow()
        {
            InitializeComponent();
        }



        
        private void sliderAge_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double age_d = sliderAge.Value;
            int age_i = (int)age_d;
            x = age_i;
            
        }

        private void btnShowGreeting(object sender, RoutedEventArgs e)
        {
            string FirstName = entryFirstName.Text;
            string LastName = entryLastName.Text;

            lblOutput.Content = "Hello, " + FirstName + " " + LastName + "! So, I see that you are " + x + " years old.";
        }
    }
}
