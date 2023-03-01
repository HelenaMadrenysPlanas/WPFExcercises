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

namespace Examen2_HelenaMadrenysPlanas
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

        //Fem els btn click i obrim la finestr corresponent
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Exercici1 ex1 = new Exercici1();
            ex1.Show();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            Exercici2 ex2 = new Exercici2();
            ex2.Show();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            Exercici3 ex3 = new Exercici3();
            ex3.Show();
        }
    }
}
