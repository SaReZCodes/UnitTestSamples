using System;
namespace Sample.Services
{
    public class SampleService
    {
        public bool IsTrue(int value)
        {
            if (value == 1)
            {
                return false;
            }
            throw new NotImplementedException("Not fully implemented.");
        }

        public bool IsNegativeNumber(int number)
        {
            if (number >= 0)
            {
                return false;
            }
            throw new NotImplementedException("Not fully implemented.");
        }
    }
}