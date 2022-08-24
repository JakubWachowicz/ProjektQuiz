using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;


namespace projekt
{

    public partial class MainWindow : Window
    {

        int i = 1;
        public int[] pyt = new int[21];


        public MainWindow()
        {
            InitializeComponent();

        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {


            Losowanie rnga = new Losowanie();
            rnga.rng(pyt);

            start.Visibility = Visibility.Hidden;
            exit.Visibility = Visibility.Hidden;
            napis.Visibility = Visibility.Hidden;
            Wyniki.Visibility = Visibility.Hidden;
            pro.Visibility = Visibility.Visible;
            name.Visibility = Visibility.Visible;
            pro.Height = 35;
            pro.Width = 160;
            ok.Visibility = Visibility.Visible;
            pro.Text = "Podaj swoje imię.";


        }



        private void Ok_Click(object sender, RoutedEventArgs e)
        {

            if (name.Text.Length < 3)
            {
                pro.Height = 65;
                pro.Width = 190;
                pro.Text = "imię powinno zawieć przynajmniej 3 znaki.";
            }

            if (name.Text.Length >= 3)
            {

                odpAll();
                name.Visibility = Visibility.Hidden;
                name1.Content = ($" {name.Text}  {i - 1}");
                ok.Visibility = Visibility.Hidden;
                restart.Visibility = Visibility.Visible;
                k1.Visibility = Visibility.Visible;
                k2.Visibility = Visibility.Visible;
                k3.Visibility = Visibility.Visible;
                pro.Height = 70;
                pro.Width = 300;
                Nextq();
            }



        }


        //sprawdzanie odpowiedzi



        private void Spr_Click(object sender, RoutedEventArgs e)
        {

            Button senderButton = sender as Button;
            if (senderButton.Tag.ToString() == "1")
            {

                i++;
                name1.Content = ($" {name.Text}  {i - 1}");
                if (i < 11)
                {
                    Next();
                }
                else
                {
                    pro.Text = "Browo wygrywasz milion złotych! Czy chcesz zapisać swój wynik";
                    Wynikizn();

                }

            }
            else
            {

                pro.Text = "Niestety to błędna odpowiedź. Czy chcesz zapisać swój wynik?";
                Wynikizn();

            }
        }



        private void Next()
        {

            odpAll();
            kt.Visibility = Visibility.Hidden;
            tablice.Visibility = Visibility.Hidden;
            Nextq();

        }

        private void Pytania(int pytanienr)
        {
            pytanienr = 5 * pytanienr;
            pro.Text = File.ReadLines(@"..\..\Pytania.txt").Skip(pytanienr).Take(1).First();
            odp1.Content = File.ReadLines(@"..\..\Pytania.txt").Skip(pytanienr + 1).Take(1).First();
            odp2.Content = File.ReadLines(@"..\..\Pytania.txt").Skip(pytanienr + 2).Take(1).First();
            odp3.Content = File.ReadLines(@"..\..\Pytania.txt").Skip(pytanienr + 3).Take(1).First();
            odp4.Content = File.ReadLines(@"..\..\Pytania.txt").Skip(pytanienr + 4).Take(1).First();


        }


        private void Restart()
        {
            i = 1;
            start.Visibility = Visibility.Visible;
            exit.Visibility = Visibility.Visible;
            napis.Visibility = Visibility.Visible;
            Wyniki.Visibility = Visibility.Visible;
            odp1.Visibility = Visibility.Hidden;
            odp2.Visibility = Visibility.Hidden;
            odp3.Visibility = Visibility.Hidden;
            odp4.Visibility = Visibility.Hidden;
            pro.Visibility = Visibility.Hidden;
            Tak.Visibility = Visibility.Hidden;
            Nie.Visibility = Visibility.Hidden;
            restart.Visibility = Visibility.Hidden;
            Wynikitxt.Visibility = Visibility.Hidden;
            tablice.Visibility = Visibility.Hidden;
            k1.Visibility = Visibility.Hidden;
            k2.Visibility = Visibility.Hidden;
            k3.Visibility = Visibility.Hidden;
            kt.Visibility = Visibility.Hidden;
            pro.Text = "";
            name.Visibility = Visibility.Hidden;
            name1.Content = " ";

        }

        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            Restart();
            restart.Visibility = Visibility.Hidden;
        }
        private void Wynik_Click(object sender, RoutedEventArgs e)
        {
            Wynikitxt.Visibility = Visibility.Visible;
            start.Visibility = Visibility.Hidden;
            exit.Visibility = Visibility.Hidden;
            napis.Visibility = Visibility.Hidden;
            Wyniki.Visibility = Visibility.Hidden;
            restart.Visibility = Visibility.Visible;



        }
        private void Tak_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"..\..\Wyniki.txt");
            sw.WriteLine(name1.Content);
            sw.Close();
            using (StreamReader sr = new StreamReader(@"..\..\Wyniki.txt"))
            {
                string q = sr.ReadToEnd();
                Wynikitxt.Text += q;
            }
            Restart();
        }
        private void Nie_Click(object sender, RoutedEventArgs e)
        {
            Restart();
        }


        private void K1_Click(object sender, RoutedEventArgs e)
        {
            K1();
            k1.Visibility = Visibility.Hidden;
        }

        private void K2_Click(object sender, RoutedEventArgs e)
        {

            kt.Visibility = Visibility.Visible;
            k2.Visibility = Visibility.Hidden;
            K2();
        }
        private void K3_Click(object sender, RoutedEventArgs e)
        {
            K3();
            tablice.Visibility = Visibility.Visible;
            k3.Visibility = Visibility.Hidden;
        }



        private void Tabela(string src)
        {
            tablice.Source = new BitmapImage(new Uri(src,UriKind.Relative));
        }

        private void Wynikizn()
        {
            Tak.Visibility = Visibility.Visible;
            Nie.Visibility = Visibility.Visible;
            odp1.Visibility = Visibility.Hidden;
            odp2.Visibility = Visibility.Hidden;
            odp3.Visibility = Visibility.Hidden;
            odp4.Visibility = Visibility.Hidden;
            k1.Visibility = Visibility.Hidden;
            k2.Visibility = Visibility.Hidden;
            k3.Visibility = Visibility.Hidden;

        }
        private void odpAll()
        {
            odp1.Visibility = Visibility.Visible;
            odp2.Visibility = Visibility.Visible;
            odp3.Visibility = Visibility.Visible;
            odp4.Visibility = Visibility.Visible;
        }

        private void o1h()
        {
            odp1.Visibility = Visibility.Hidden;
        }
        private void o2h()
        {
            odp2.Visibility = Visibility.Hidden;
        }
        private void o3h()
        {
            odp3.Visibility = Visibility.Hidden;
        }
        private void o4h()
        {
            odp4.Visibility = Visibility.Hidden;
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
