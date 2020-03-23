using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tanveer_dog_race_master
{
    public static class Punter
    {
        //another static class that is used to generate the budget of the player 
        public static int frst=100, scnd = 100, thrd = 100;

            //all static method that is used to pass the budget of the player 
        public static int firstbetter(int budget) { frst = budget; return frst;}
        public static int scndbetter(int budget){ scnd = budget; return scnd;}
        public static int thrdbetter(int budget){ thrd = budget; return thrd;}
        
    }
}
