using System;

namespace PrimeService
{
    public class PrimeService
    {
        public bool IsPrime(int num)
        {
            //one
            if (num == 1)
                return false;
            //two
            if (num < 2)
                return false;
            //three
            if (num == 2)
                return true;
            //four
            if (num == 3)
                return true;
            //five
            if (num % 2 == 0)
                return false;
            //six
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
