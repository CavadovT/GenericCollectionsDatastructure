using System;
using System.Collections.Generic;
using BookLibraryPruduct.Models;


namespace BookLibraryPruduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region test capasitini yoxlamaq
            //try
            //{
            //    //List<int> list = new List<int>();
            //    //list.Add(1);
            //    //list.Add(2);
            //    //list.Add(3);

            //   // LinkedList<int> list2 = new LinkedList<int>();
            //    //list2.
            //    //Console.WriteLine("count:  " + list.Count);

            //    //Console.WriteLine("capasit:  " + list.Capacity);
            //    //list.Capacity = 2;
            //   // list.Capacity = 0;// error cixmir yeni capasity countdan kicik olsa cixacaq error

            //    //int[] arr = new int[2];
            //    //Console.WriteLine(arr[2]);

            //    //Console.WriteLine(arr.Rank);


            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);

            //}
            #endregion

            /*
             Program class:
            Yazdıqlarınızı test etmək.
             */
            Book book1 = new Book("Problems Mathematical", "B.Demidovich", 50, 150) { Count=5};
            book1.ShowInfo();
            Book book2 = new Book("Rich Dad & Poor Dad", "R.KIyosaki and SH.Lechter", 50, 600){Count=6};
            book2.ShowInfo();   
            Book book3 = new Book("Ali riyaziyyat1", "Reshid Memmedov", 18, 500) { Count = 10 };
            book3.ShowInfo();

          //  book1.Sell();
           // book1.ShowInfo();
            List<Book> books = new List<Book>();
            //books.Add(book1);
            //books.Add(book2);
            Library library = new Library(20);
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
           // library.RemoveByID(3);

            //library.GetBookByID(3);
           // library.GetBookByID(3);
           // book3.Sell();

            

        }
    }
}