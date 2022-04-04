using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibraryPruduct.Models
{
     class Book:Product
    {
                /*
                 Book class (Product-dan miras alır)
        - AuthorName
        - PageCount
        
        ShowInfo methodunu override edir və bütün book-un məlumatlarını console-a çıxardır.
        Sell methodunu override edir və 
                hər dəfə sell methodu işə düşəndə bir ədəd book satılmalıdır 
                count azalır TotalInCome isə artır, 
                əgər Product-ın count-ı sıfır olarsa o zaman ProductCountIsZeroException baş versin və 
                satış baş verməsin.
        
        ps: name, price, authorName, pageCount dəyərləri olmadan book obyekti yaratmaq olmaz.
        */
        
        public Book(string name)
        {
           
        }
    }
}
