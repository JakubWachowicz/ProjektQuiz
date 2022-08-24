using System;

namespace projekt
{
    partial class MainWindow
    {
        private string K2rng(int x)
        {
            Random rnd = new Random();
            int z = rnd.Next(1, 5);
            while ( x == z)
            {
                 z = rnd.Next(1, 5);
            }
           if(z == 1)
            {
                return "a";
            }
            else if(z == 2)
            {
                return "b";
             }
            else if (z == 3)
            {
                return "c";
            }
            else 
            {
                return "d";
            }
            
        }
        private void K2()
        {
           
            Random rnd = new Random();

            int rng1 = rnd.Next(1, 11);
            if (rng1 == 1 || rng1 == 2 || rng1 == 3 || rng1 == 4)
            {
                if (Convert.ToString(odp1.Tag) == "1")
                {
                    kt.Text = "Wydaje mi się że poprawną odopwiedzią jest odpowiedź a";
                }
                if (Convert.ToString(odp2.Tag) == "1")
                {
                    kt.Text = "Wydaje mi się że poprawną odopwiedzią jest odpowiedź b";
                }
                if (Convert.ToString(odp3.Tag) == "1")
                {
                    kt.Text = "Wydaje mi się że poprawną odopwiedzią jest odpowiedź c";
                }
                if (Convert.ToString(odp4.Tag) == "1")
                {
                    kt.Text = "Wydaje mi się że poprawną odopwiedzią jest odpowiedź d";
                }
            }
            if (rng1 == 5 || rng1 == 6 || rng1 == 7 || rng1 == 8)
            {
                int rng2 = rnd.Next(1, 3);

                if (Convert.ToString(odp1.Tag) == "1")
                {
                    string z = "a";                           
                    kt.Text = $"Wydaje mi się, że poprawną odpowiedzią jest {K2rng(1)} lub {z}";           

                }
                if (Convert.ToString(odp2.Tag) == "1")
                {
                    string z = "b";
                    kt.Text = $"Wydaje mi się, że poprawną odpowiedzią jest {K2rng(2)} lub {z}";
                    
               
                }
                if (Convert.ToString(odp3.Tag) == "1")
                {
                    string z = "c";
                    kt.Text = $"Wydaje mi się, że poprawną odpowiedzią jest {K2rng(3)} lub {z}";
                    
                }
                if (Convert.ToString(odp4.Tag) == "1")
                {
                    string z = "d";
                    kt.Text = $"Wydaje mi się, że poprawną odpowiedzią jest {K2rng(4)} lub {z}";
                    

                }


            }
            if (rng1 == 9 || rng1 == 10)
            {
                int rng3 = rnd.Next(1, 5);
                if (rng3 == 1)
                {
                    kt.Text = "Wydaje mi się że poprawną odpowiedzią jest odpowiedź a";
                }
                if (rng3 == 2)
                {
                    kt.Text = "Wydaje mi się że poprawną odpowiedzią jest odpowiedź b";
                }
                if (rng3 == 3)
                {
                    kt.Text = "Wydaje mi się że poprawną odpowiedzią jest odpowiedź c";
                }
                if (rng3 == 4)
                {
                    kt.Text = "Wydaje mi się że poprawną odpowiedzią jest odpowiedź d";
                }
            }

        }
    }
}
