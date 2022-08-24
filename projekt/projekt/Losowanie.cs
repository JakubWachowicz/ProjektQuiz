using System;
using System.Collections.Generic;


namespace projekt
{
    struct Losowanie
    {
        public void rng(int[] arr)
        {
            Random rnd = new Random();
            int t = 0;
            HashSet<int> pytl = new HashSet<int>();
            while (pytl.Count < 11)
            {
                pytl.Add(rnd.Next(1, 21));
            }
            foreach (int ru in pytl)
            {
                arr[t] = ru;
                t++;
            }

        }
    }
}
