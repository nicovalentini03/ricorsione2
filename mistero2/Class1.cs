using System;

namespace mistero2
{


    public class Calcoli
    {
        public static int mistero2(int x, int y)
        {

            if (y == 0)
            {
                return 0;
            }
            else
            {

                return (mistero1(x, mistero2(x, y - 1)));
            }

        }

        public static int mistero1(int x, int y)
        {
            int prec;
            if (y == 0)
            {
                return x;
            }
            else
            {
                prec = mistero1(x, y - 1) + 1;
                return prec;
            }
        }
    }   
}




     