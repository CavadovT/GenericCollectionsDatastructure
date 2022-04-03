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
            if (capacity >= count) 
            {
                throw new Exception("capacity was less than the current size. (Parameter 'value')");
            }
        }
    }
}
