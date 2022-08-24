using System;
using System.Collections.Generic;

namespace projekt
{
    partial class MainWindow 
    {
        private void K1()
        {
            Random rnd = new Random();
            int t = 0;
            int[] rngt = new int[10];


            HashSet<int> rng = new HashSet<int>();
            while (rng.Count < 4)
            {
                rng.Add(rnd.Next(1, 5));
            }
            foreach (int ru in rng)
            {
                rngt[t] = ru;
                t++;
            }
            t = 0;
            int i = 0;

            while (i < 2)
            {



                if (rngt[t] == 1)
                {
                    if (Convert.ToString(odp1.Tag) == "0")
                    {
                        o1h();
                        i++;
                        t++;
                    }


                }
                else if (rngt[t] == 2)
                {
                    if (Convert.ToString(odp2.Tag) == "0")
                    {
                        o2h();
                        t++;
                        i++;
                    }


                }
                else if (rngt[t] == 3)
                {
                    if (Convert.ToString(odp3.Tag) == "0")
                    {
                        o3h();
                        t++;
                        i++;
                    }


                }
                else if (rngt[t] == 4)
                {
                    if (Convert.ToString(odp4.Tag) == "0")
                    {
                        o4h();
                        t++;
                        i++;
                    }


                }
                t++;


            }
        }
    }
}
