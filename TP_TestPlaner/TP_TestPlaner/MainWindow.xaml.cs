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
using System.Data.SqlClient;

namespace TP_TestPlaner
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //InitializeComponent();
            //SqlConnection myConnection = new SqlConnection("server=localhost;" +
            //                           "Trusted_Connection=yes;" +
            //                           "database=testDB; " +
            //                           "connection timeout=30");
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Testauftrag_hinzu TA_hinzu = new Testauftrag_hinzu();
            TA_hinzu.ShowDialog();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Testauftrag_bearbeiten TA_bearbeiten = new Testauftrag_bearbeiten();
            TA_bearbeiten.ShowDialog();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Verwaltung_Tester Verwalten = new Verwaltung_Tester();
            Verwalten.ShowDialog();
        }
    }
}
