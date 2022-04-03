using System;
using System.Collections.Generic;

namespace BookLibraryPruduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region test 
            try
            {
                List<int> list = new List<int>();
               list.Add(1);
                list.Add(2);
                list.Add(3);
               
                Console.WriteLine("count:  "+list.Count);

                Console.WriteLine("capasit:  "+list.Capacity);
                list.Capacity = 2;
                list.Capacity = 3;// error cixmir yeni capasity countdan kicik olsa cixacaq error



            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            #endregion
        }
    }
}
