using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tanveer_dog_race_master
{
   public static class Running
   {
        //instance of the random class to generate the random no 
        static Random instance_random = new Random();

        // this is static method that is used to generate the no from random class to move the dog from one position to another   
        public static int move() {
            //return the random no 
            return instance_random.Next(1, 40);
        }

        public static int pause(int position) {
            if (position>=730) {
                return 1;
            }return 0;
        }

   }
}
