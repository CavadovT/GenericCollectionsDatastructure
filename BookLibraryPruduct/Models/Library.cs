using System;
using System.Collections.Generic;
using System.Text;
using BookLibraryPruduct.Helper;

namespace BookLibraryPruduct.Models
{
     class Library
    {
        /*
         * Library class
             - BookLimit
            - Books - List olacaq
            - AddBook() - Parametr olaraq bir Book obyekti qəbul edir və 
        books listinə əlavə edir əgər
        BookLimiti aşırsa geriyə CapacityLimitException qaytarsın
            - GetBookById() - Parametr olaraq nullable bir id qəbul edir
        və o Book obyektini tapıb geriyə qaytarır 
        əgər id null olarsa geriyə NullReferenceException qaytarsın ümumiyyətlə
        göndərilən id-li book-u tapmasa geriyə null qaytarsın.
            - RemoveById() - Parametr olaraq nullable bir id qəbul edir 
        və o Book obyektini tapıb Books listindən silir
        əgər id null olarsa geriyə NullReferenceException qaytarsın 
        ümumiyyətlə göndərilən id-li book-u tapmasa geriyə NotFoundException qaytarsın.
            
            
            ps: BookLimit olmadan Library obyekti yaratmaq olmaz.
         
         */
        public int BookLimit { get; set; }
        public int Count { get; set; }
        
        List<Book> books = new List<Book>();
        public Library(int bookLimit):base()
        {
            BookLimit = bookLimit;
           
        }
        public void AddBook(Book book)
        {
           
            int counttotal=book.Count;

            foreach (Book item in books)
            {
                counttotal=counttotal+item.Count;

            }
            if (counttotal >= BookLimit) 
            {
                Helper.Exceptions.CapacityLimitException(BookLimit, counttotal);
                return;
            }

            books.Add(book);
            Console.WriteLine("Book added to Library");
           
        }
        public void GetBookByID(int? id) 
        {
          
            bool exist = false;
            foreach (Book item in books)
            {
                if (id == item.ID)
                {
                    Console.WriteLine(item);
                    exist = true;
                    return;
                }
            }
            if (exist == false &&((id is null)==false))
               Helper.Exceptions.NotFoundException();
            if (id is null)
            {
              
                throw new NullReferenceException("Id Is null!!");
            }



        }
        public void RemoveByID(int? id)
        {
            
            int k=0;
            bool notExist = false;
            for (int i = 0; i < books.Count ; i++)
            {
                
                if (id == books[i].ID)
                {
                    books[i].Count=0;
                    Console.WriteLine($"with {id} Id deleted in library");
                    notExist = true;
                    k = i;
                }
            }
             if (notExist = true)
            {
                books[k].ShowInfo();
            }
            else if (notExist == false && !(id is null))
            {
                Helper.Exceptions.NotFoundException();
            }
            else if (id is null)
            {
                throw new NullReferenceException("Id is null");
            }
           
           
        
        }
    }
}
