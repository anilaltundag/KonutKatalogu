using System;
using System.Collections.Generic;
using System.IO;
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

namespace konut_katalogu_uygulaması
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            combobox1.Items.Add("Daire-1");
            combobox1.Items.Add("Daire-2");
            combobox1.Items.Add("Daire-3");
            combobox1.Items.Add("Villa-1");
            combobox1.Items.Add("Villa-2");
            combobox1.Items.Add("Villa-3");
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            textblock2.Text = "";
            textblock3.Text = "";
            textblock4.Text = "";
            textblock5.Text = "";
            textblock6.Text = "";
            textblock7.Text = "";

            if (combobox1.Text == "Daire-1")
            {
                FileStream fs = new FileStream(@"C:\Users\ANIL\Desktop\Mülakat\daire1.txt", FileMode.Open);
                StreamReader oku = new StreamReader(fs);
                textblock1.Text = oku.ReadToEnd();
                oku.Close();
                fs.Close();
            }
            else if (combobox1.Text == "Daire-2")
            {
                FileStream fs = new FileStream(@"C:\Users\ANIL\Desktop\Mülakat\daire2.txt", FileMode.Open);
                StreamReader oku = new StreamReader(fs);
                textblock1.Text = oku.ReadToEnd();
                oku.Close();
                fs.Close();
            }
            else if (combobox1.Text == "Daire-3")
            {
                FileStream fs = new FileStream(@"C:\Users\ANIL\Desktop\Mülakat\daire3.txt", FileMode.Open);
                StreamReader oku = new StreamReader(fs);
                textblock1.Text = oku.ReadToEnd();
                oku.Close();
                fs.Close();
            }
            else if (combobox1.Text == "Villa-1")
            {
                FileStream fs = new FileStream(@"C:\Users\ANIL\Desktop\Mülakat\villa1.txt", FileMode.Open);
                StreamReader oku = new StreamReader(fs);
                textblock1.Text = oku.ReadToEnd();
                oku.Close();
                fs.Close();
            }
            else if (combobox1.Text == "Villa-2")
            {
                FileStream fs = new FileStream(@"C:\Users\ANIL\Desktop\Mülakat\villa2.txt", FileMode.Open);
                StreamReader oku = new StreamReader(fs);
                textblock1.Text = oku.ReadToEnd();
                oku.Close();
                fs.Close();
            }
            else if (combobox1.Text == "Villa-3")
            {
                FileStream fs = new FileStream(@"C:\Users\ANIL\Desktop\Mülakat\villa3.txt", FileMode.Open);
                StreamReader oku = new StreamReader(fs);
                textblock1.Text = oku.ReadToEnd();
                oku.Close();
                fs.Close();
            }
            else
            {
                MessageBox.Show("Lütfen bir seçim yapınız!");
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            textblock1.Text = "";

            FileStream fs = new FileStream(@"C:\Users\ANIL\Desktop\Mülakat\daire1.txt", FileMode.Open);
            StreamReader oku = new StreamReader(fs);
            string ilkSatir = oku.ReadLine();
            string ucuncuSatir = oku.ReadLine() + oku.ReadLine();
            textblock2.Text = ilkSatir + '\n' + ucuncuSatir;
            oku.Close();
            fs.Close();

            FileStream fs2 = new FileStream(@"C:\Users\ANIL\Desktop\Mülakat\daire2.txt", FileMode.Open);
            StreamReader oku2 = new StreamReader(fs2);
            string ilkSatir2 = oku2.ReadLine();
            string ucuncuSatir2 = oku2.ReadLine() + oku2.ReadLine();
            textblock3.Text = ilkSatir2 + '\n' + ucuncuSatir2;
            oku2.Close();
            fs2.Close();

            FileStream fs3 = new FileStream(@"C:\Users\ANIL\Desktop\Mülakat\daire3.txt", FileMode.Open);
            StreamReader oku3 = new StreamReader(fs3);
            string ilkSatir3 = oku3.ReadLine();
            string ucuncuSatir3 = oku3.ReadLine() + oku3.ReadLine();
            textblock4.Text = ilkSatir3 + '\n' + ucuncuSatir3;
            oku3.Close();
            fs3.Close();

            FileStream fs4 = new FileStream(@"C:\Users\ANIL\Desktop\Mülakat\villa1.txt", FileMode.Open);
            StreamReader oku4 = new StreamReader(fs4);
            string ilkSatir4 = oku4.ReadLine();
            string ucuncuSatir4 = oku4.ReadLine() + oku4.ReadLine();
            textblock5.Text = ilkSatir4 + '\n' + ucuncuSatir4;
            oku4.Close();
            fs4.Close();

            FileStream fs5 = new FileStream(@"C:\Users\ANIL\Desktop\Mülakat\villa2.txt", FileMode.Open);
            StreamReader oku5 = new StreamReader(fs5);
            string ilkSatir5 = oku5.ReadLine();
            string ucuncuSatir5 = oku5.ReadLine() + oku5.ReadLine();
            textblock6.Text = ilkSatir5 + '\n' + ucuncuSatir5;
            oku5.Close();
            fs5.Close();

            FileStream fs6 = new FileStream(@"C:\Users\ANIL\Desktop\Mülakat\villa3.txt", FileMode.Open);
            StreamReader oku6 = new StreamReader(fs6);
            string ilkSatir6 = oku6.ReadLine();
            string ucuncuSatir6 = oku6.ReadLine() + oku6.ReadLine();
            textblock7.Text = ilkSatir6 + '\n' + ucuncuSatir6;
            oku6.Close();
            fs6.Close();
        }
    }
}
