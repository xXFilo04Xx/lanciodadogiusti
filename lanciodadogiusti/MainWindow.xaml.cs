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

namespace lanciodadogiusti
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(txtnumero.Text);
            if(a > 6 || a < 1)
            {
                MessageBox.Show("MA CI SEI O CI FAI", "ERRORE", MessageBoxButton.OK, MessageBoxImage.Error);
                txtnumero.Clear();
            }else
            {
                Random r = new Random();
                int b = r.Next(1, 7);
                if (a == b)
                {
                    txtrisultato.Text = string.Format("BOMBER");
                }
                else
                {
                    txtrisultato.Text = string.Format("FAI SCHIFO");
                    a = 0;
                    b = 0;
                }
            }

        }
    }
}
