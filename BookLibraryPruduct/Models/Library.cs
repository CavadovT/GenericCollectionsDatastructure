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
        public Library(int bookLimit)
        {
            BookLimit = bookLimit;
           
        }
        public void AddBook(Book book) 
        {
        if (Count==BookLimit)
        }
        public void GetBookByID(int? id) 
        {  
            if (id != null) 
            {
                foreach (var item in books)
                {
                    if (item.ID == id)
                    {
                        item.Info();
                     
                        return;
                    }
                    
                }
            }
           
          
        }

       
    }
}
