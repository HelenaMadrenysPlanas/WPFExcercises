using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Examen2_HelenaMadrenysPlanas
{
    /// <summary>
    /// Interaction logic for Exercici3.xaml
    /// </summary>
    public partial class Exercici3 : Window
    {
        //Declarem un llistat d'alumnes
        List<Alumne> alumnes = new List<Alumne>();

        //Creem els alumnes i els hi passem al constructor les dades
        Alumne alumne1 = new Alumne("Helena", "Madrenys", "hmadrenys@gmail.com", @".\Recursos\megan.jpg");
        Alumne alumne2 = new Alumne("Albert", "Madrenys", "albertbrother@gmail.com", @".\Recursos\stewie.jpg");
        Alumne alumne3 = new Alumne("Pere", "Madrenys", "perepare@gmail.com", @".\Recursos\peter.jpg");
        Alumne alumne4 = new Alumne("Anna", "Planas", "annamare@gmail.com", @".\Recursos\lois.png");

        public Exercici3()
        {
            InitializeComponent();

            //Inserim els alumnes a la llista
            alumnes.Add(alumne1);
            alumnes.Add(alumne2);
            alumnes.Add(alumne3);
            alumnes.Add(alumne4);

            //Inserim la llista al ListView
            listView.ItemsSource = alumnes;
        }
    }
}
