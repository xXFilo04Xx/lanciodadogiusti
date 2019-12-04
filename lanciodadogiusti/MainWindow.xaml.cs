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
            double credito = double.Parse(txtcredito.Text);
            double puntata = double.Parse(txtpuntata.Text);
            if (puntata < credito)
            {

            }
            else
            {
                MessageBox.Show("IMPOSSIBILE", "NABBO", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if (a > 6 || a < 1)
            {
                MessageBox.Show("MA CI SEI O CI FAI", "ERRORE", MessageBoxButton.OK, MessageBoxImage.Error);
                txtnumero.Clear();
            }
            else
            {
                Random r = new Random();
                int b = r.Next(1, 7);
                if (a == b)
                {
                    txtrisultato.Text = "BOMBER";
                    txtrandom.Text = $"{b}";
                    credito = puntata * 2 + credito;
                    txtcredito.Text = $"{credito}";
                }
                else
                {
                    txtrisultato.Text = "FAI SCHIFO";
                    txtrandom.Text = $"{b}";
                    credito = credito - puntata;
                    txtcredito.Text = $"{credito}";
                    a = 0;
                    b = 0;
                }
                if (credito <= 0)
                {
                    MessageBox.Show("GAME OVER", "NABBO", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }


        }

        private void txtriprova_Click(object sender, RoutedEventArgs e)
        {
            txtnumero.Clear();
            txtpuntata.Clear();
            txtcredito.Text = "100";
        }
    }
}
