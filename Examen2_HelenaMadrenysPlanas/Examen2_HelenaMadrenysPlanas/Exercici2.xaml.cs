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
    /// Interaction logic for Exercici2.xaml
    /// </summary>
    public partial class Exercici2 : Window
    {
        public Exercici2()
        {
            InitializeComponent();
        }
    }
    //Creem la classe que farà de converter i la fem amb la interfície IValueConverter
    public class FloatToColor : IValueConverter
    {
        //Métode per passar de Float a Color
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            //Passem el valor a string i després a float per a poder-lo tractar
            float num = float.Parse(value.ToString());

            //Segons el nombre retornem un color o un altre
            if (num >= 0 && num <= 20)
            {
                return Brushes.Blue;
            } else if (num > 20 && num <= 40)
            {
                return Brushes.Green;
            } else
            {
                return Brushes.Red;
            }
        }

        //Metode per passar de Color a Float, no hi hem posat res perquè no el fem servir
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value;
        }
    }
}
