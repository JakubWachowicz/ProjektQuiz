using System;


namespace projekt
{
    public partial class MainWindow  
    {

        private void K3()
        {
            

            Random rnd = new Random();

            int rng1 = rnd.Next(1, 11);
            if (rng1 == 1 || rng1 == 2 || rng1 == 3 || rng1 == 4)
            {
                if (Convert.ToString(odp1.Tag) == "1")
                {
                    Tabela(@"..\..\tabele\tabela1.png");
                }
                if (Convert.ToString(odp2.Tag) == "1")
                {
                    Tabela(@"..\..\tabele\tabela3.png");
                }
                if (Convert.ToString(odp3.Tag) == "1")
                {
                    Tabela(@"..\..\tabele\tabela5.png");
                }
                if (Convert.ToString(odp4.Tag) == "1")
                {
                    Tabela(@"..\..\tabele\tabela6.png");
                }
            }
            if (rng1 == 5 || rng1 == 6 || rng1 == 7 || rng1 == 8)
            {


                if (Convert.ToString(odp1.Tag) == "1")
                {

                    int trng = rnd.Next(1, 5);
                    if (trng == 1)
                    {
                        Tabela(@"..\..\tabele\tabela9.png");
                    }
                    else if (trng == 2)
                    {
                        Tabela(@"..\..\tabele\tabela10.png");
                    }
                    else if (trng == 3)
                    {
                        Tabela(@"..\..\tabele\tabela12.png");
                    }
                    else if (trng == 4)
                    {
                        Tabela(@"..\..\tabele\tabela13.png");
                    }
                }
                if (Convert.ToString(odp2.Tag) == "1")
                {

                    int trng = rnd.Next(1, 5);
                    if (trng == 1)
                    {
                        Tabela(@"..\..\tabele\tabela9.png");
                    }
                    else if (trng == 2)
                    {
                        Tabela(@"..\..\tabele\tabela8.png");
                    }
                    else if (trng == 3)
                    {
                        Tabela(@"..\..\tabele\tabela7.png");
                    }
                    else if (trng == 4)
                    {
                        Tabela(@"..\..\tabele\tabela14.png");
                    }
                }
                if (Convert.ToString(odp3.Tag) == "1")
                {

                    int trng = rnd.Next(1, 5);
                    if (trng == 1)
                    {
                        Tabela(@"..\..\tabele\tabela12.png");
                    }
                    else if (trng == 2)
                    {
                        Tabela(@"..\..\tabele\tabela8.png");
                    }
                    else if (trng == 3)
                    {
                        Tabela(@"..\..\tabele\tabela7.png");
                    }
                    else if (trng == 4)
                    {
                        Tabela(@"..\..\tabele\tabela15.png");
                    }
                }
                if (Convert.ToString(odp4.Tag) == "1")
                {

                    int trng = rnd.Next(1, 5);
                    if (trng == 1)
                    {
                        Tabela(@"..\..\tabele\tabela16.png");
                    }
                    else if (trng == 2)
                    {
                        Tabela(@"..\..\tabele\tabela14.png");
                    }
                    else if (trng == 3)
                    {
                        Tabela(@"..\..\tabele\tabela7.png");
                    }
                    else if (trng == 4)
                    {
                        Tabela(@"..\..\tabele\tabela15.png");
                    }

                }


            }
            if (rng1 == 9 || rng1 == 10)
            {
                int rng3 = rnd.Next(1, 5);
                if (rng3 == 1)
                {
                    Tabela(@"..\..\tabele\tabela7.png");
                }
                if (rng3 == 2)
                {
                    Tabela(@"..\..\tabele\tabela15.png");
                }
                if (rng3 == 3)
                {
                    Tabela(@"..\..\tabele\tabela1.png");
                }
                if (rng3 == 4)
                {
                    Tabela(@"..\..\tabele\tabela2.png");
                }
            }
        }

    }
}
