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
using PairNumber;

namespace Lab_6
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

        private void resolution(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(firstP1.Text, out double initiFirstP1) && double.TryParse(firstP2.Text, out double initiFirstP2)
                && double.TryParse(secondP1.Text, out double initiSecondP1) && double.TryParse(secondP2.Text, out double initiSecondP2))
            {
                Pair pair1 = new Pair(initiFirstP1, initiSecondP1);
                Pair pair2 = new Pair(initiFirstP2, initiSecondP2);
                if (pair1 > pair2 || (pair1 == pair2 && pair1 > pair2))
                {
                    rez.Text = "Перая пара чисел больше, чем вторая";
                }
                else
                {
                    rez.Text = "Вторая пара чисел больше, чем первая";
                }
            }
            else MessageBox.Show("Поля не заполнены или заполнены не верно");
        }

        private void exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" ИСП-31, Сергиенко, 4. Создать класс Pair (пара чисел). Создать необходимые методы и свойства. " +
                " Определить метод сравнения пар: пара p1 больше пары р2, если (first.pl > first.р2)  или (first.pl = first.р2) и (second.pl > second.р2)." +
                " Создать перегруженные методы  SetParams, для установки параметров объекта.");
        }

        private void reset(object sender, RoutedEventArgs e)
        {
            firstP1.Clear();
            firstP2.Clear();
            secondP1.Clear();
            secondP2.Clear();
            rez.Clear();

        }

        private void firstP1_TextChanged(object sender, TextChangedEventArgs e)
        {
            rez.Clear();
        }

        private void secondP1_TextChanged(object sender, TextChangedEventArgs e)
        {
            rez.Clear();
        }

        private void firstP2_TextChanged(object sender, TextChangedEventArgs e)
        {
            rez.Clear();
        }

        private void secondP2_TextChanged(object sender, TextChangedEventArgs e)
        {
            rez.Clear();
        }
    }
}
