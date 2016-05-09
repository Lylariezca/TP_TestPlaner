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
using System.Windows.Shapes;

namespace TP_TestPlaner
{
    /// <summary>
    /// Interaktionslogik für Verwaltung_Tester.xaml
    /// </summary>
    public partial class Verwaltung_Tester : Window
    {
        public Verwaltung_Tester()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Tester_hinzu Thinzu = new Tester_hinzu();
            Thinzu.ShowDialog();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
