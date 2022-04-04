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
                throw new Exception("capacity was less than the current size. (Parameter 'value')");
            }
        }
        public static void NotFoundException() 
        {
            throw new Exception("NotFoundThisBook");
        }
        public static void ProductCountIsZeroException(int count) 
        {
            if (count == 0)
            {
                throw new Exception("This book is not int the base");
            }
        }
    }
}
