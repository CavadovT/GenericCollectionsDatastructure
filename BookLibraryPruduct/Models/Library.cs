using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibraryPruduct.Models
{
     class Library
    {
        List<Book> books = new List<Book>();
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
