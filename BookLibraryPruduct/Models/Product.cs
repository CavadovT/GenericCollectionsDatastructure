using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibraryPruduct.Models
{
    abstract class Product    //okay
    {
        /*
                 
        Product abstrakt class
        - Id - qıraqdan set etmək olmayacaq yalnız get etmək olacaq və hər dəfə yeni bir Book obyekt yaradıldıqda avtomatik bir vahid artacaq.
        - Name
        - Price
        - Count
        - TotalInCome - book satışlarından alınan gəlir sadəcə Productın miras verdiyi class-larda set etmək olar
        - Sell() - abstrakt method olacaq
        - ShowInfo() - abstrakt method olacaq

         */
        
        private static int _id;
        public int ID { get; }
        public string  Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        protected  double TotalInCome { get; set; }

        public Product()
        {
            _id++;
            ID = _id;
        }
        public abstract void Sell();
        public abstract void ShowInfo();
    }
}
