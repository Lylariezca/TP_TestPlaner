﻿using System;
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
    /// Interaktionslogik für Testauftrag_bearbeiten.xaml
    /// </summary>
    public partial class Testauftrag_bearbeiten : Window
    {
        public Testauftrag_bearbeiten()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}