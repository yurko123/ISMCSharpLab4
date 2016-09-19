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

namespace WpfApplication1
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            /*  string a = (string)((Button)e.OriginalSource).Content;
              int i;
             // i=(int)(textBlock.)
            //  MessageBox.Show(,"windows");
              int a = textBox. 
              textBlock.Text += Pi_Viet(a);
              textBlock2.Text += Pi_Leybnitc(10);*/
        }
        double Pi_Viet(int i)
        {
            double a = Math.Sqrt(0.5), c = a, b;

            for (int j = 0; j < i; j++)
            {
                b = Math.Sqrt(0.5 + 0.5 * a);
                c *= b;
                a = b;
            }

            return 2 / c;
        }

        double Pi_John(int i)
        {
            double a = 1;
            for (int j = 2; j <= i * 2; j += 2)
            {

                a *= ((j - 1) * (j + 1) * 1.0) / (j * j);
            }
            return 2 / a;
        }

        double Pi_Lord(int i)
        {
            double temp = i * 2 + 1;
            for (int j = i * 2 - 1; j > 1; j -= 2)
            {
                temp = 2 + (j * j * 1.0) / temp;

            }
            return 4.0 / (1.0 / temp + 1);
        }

        double Pi_Leybnitc(int i)
        {
            double a = 0;
            for (int j = 1, k = 2; j <= i * 2; j += 2, k++)
            {
                if (k % 2 == 0) a += 1.0 / j;
                else a -= 1.0 / j;

            }
            return 4.0 * a;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {


            int i = Int32.Parse(num1.Text), j = Int32.Parse(num2.Text), m = Int32.Parse(num3.Text), n = Int32.Parse(num4.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Text += Pi_Viet(i);
            textBox2.Text += Pi_John(j);
            textBox3.Text += Pi_Lord(m);
            textBox4.Text += Pi_Leybnitc(n);
        }



    }
}
