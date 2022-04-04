using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibraryPruduct.Helper
{
    static class Exceptions
    {
        /*
        Aşağıdakı custom exceptionları yaradın:
            - CapacityLimitException
            - NotFoundException
            - ProductCountIsZeroException

         */
        public static void CapacityLimitException(int capacity, int count) 
        {
            if (capacity < count) 
            {
                Console.WriteLine(new Exception("capacity was less than the current size. (Parameter 'value')"));
            }
        }
        public static void NotFoundException() 
        {
            Console.WriteLine( new Exception("Notfound"));

        }
        public static void ProductCountIsZeroException(int count) 
        {
            if (count == 0)
            {
                Console.WriteLine( new Exception("This book is not int the base"));
                return;
            }
        }
    }
}
