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
using WpfAppIntroduktionString.BIZ;

namespace WpfAppIntroduktionString
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClassBIZ classBIZ = new ClassBIZ();

        public MainWindow()
        {
            InitializeComponent();
            classBIZ.GetTextForTextBox(textBox1);
        }

        private void Opg21_Click(object sender, RoutedEventArgs e)
        {
            textBox2.Text = $"Teksten indeholder {classBIZ.CountAllLines(textBox1)} linjer.";
        }

        private void Opg22_Click(object sender, RoutedEventArgs e)
        {
            textBox2.Text = $"Teksten indeholder {classBIZ.CountAllChars(textBox1)} tegn.";
        }

        private void Opg23_Click(object sender, RoutedEventArgs e)
        {
            textBox2.Text = $"Teksten indeholder {classBIZ.CountAllVokals(textBox1)} vokaler.";
        }

        private void Opg24_Click(object sender, RoutedEventArgs e)
        {
            textBox2.Text = classBIZ.RemoveAllVokals(textBox1);
        }

        private void Opg25_Click(object sender, RoutedEventArgs e)
        {
            textBox2.Text = classBIZ.MarkAndCountWord(textBox1, input.Text);
        }
    }
}
