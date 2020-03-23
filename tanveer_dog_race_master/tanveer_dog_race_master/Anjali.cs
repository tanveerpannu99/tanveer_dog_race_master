using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tanveer_dog_race_master
{
    public static class Anjali
    {
        public static int winnner(String budget, int frst, int winner)
        {
            //anu choose dog 1 and 10
            String[] data = budget.Split(' ');
            if (winner == Convert.ToInt32(data[3]))
            {
                return frst + Convert.ToInt32(data[5]);
            }
            else
            {
                return frst - Convert.ToInt32(data[5]);

            }


        }

    }
}
