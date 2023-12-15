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

namespace MDK10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void About(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Агальцов Д. ИСП-31 Практическая работа №10:Дан массив в диапазоне [-100;100] найти количество положительных и отрицательных.");
        }

        private void Start(object sender, RoutedEventArgs e)
        {
            int pol = 0;
            int otr = 0;
            bool f = Int32.TryParse(tb3.Text, out int a);
            if (f && a > 0)
            {
                
                Random rnd = new Random();
                List <int> mas = new List<int>();
                for(int i = 0; i < a; i++)
                {
                    int k = rnd.Next(-100,101);
                    mas.Add(k);
                    lb.Items.Add(k);
                }
                foreach(int s in mas)
                {
                    if(s>0)
                    {
                        pol++;
                    tb2.Text=pol.ToString();
                    }
                    else
                    {
                        otr++;
                    }
                    tb1.Text = otr.ToString();
                }

            }
            else MessageBox.Show("Укажите положительную длинну массива");
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            lb.Items.Clear();
            tb1.Clear();
            tb2.Clear();
            tb3.Clear();
        }
    }
}
