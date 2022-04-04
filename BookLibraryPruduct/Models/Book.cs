using BookLibraryPruduct.Helper;
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

        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public Book(string name,string authorName,double price,int pageCount)
        {
            Name = name;
            AuthorName = authorName;
            Price = price;
            PageCount = pageCount;
            

        }
        public override void Sell()
        {
            Exceptions.ProductCountIsZeroException(Count);
            Count--;
            TotalInCome += Price*30/100.0;
        }

        public override void ShowInfo()
        {
           
            Console.Write($"\nProduct Id:{ID}\nBook Name: {Name}\nAouthor Name: {AuthorName}\n" +
                $"Page Count: {PageCount}\nPrice: {Price}\nCount in base: {Count}\n" +
                $"TotalInCome: {TotalInCome}\n");
            Console.WriteLine("+++++++++++++++++++++++++");
        }
        public override string ToString()
        {
            return $"\nProduct Id:{ID}\n Book Name: {Name}\n Aouthor Name: {AuthorName}\n" +
                $"Page Count: {PageCount}\nPrice: {Price}\nCount in base: {Count}\n" +
                $"Total In Come : {TotalInCome}\n" + "++++++++++++++++";
        }
    }
}
