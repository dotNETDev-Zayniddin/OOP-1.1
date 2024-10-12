using System;
namespace OOP
{
    class Book
    {
        private int price = 50;                          //fields
        
        public string Author 
        { 
            get {return "Steeve Jobs";}                 //priv o'zgaruvchi o'rniga Prop set qilib bo'lmaydigan qo'yildi(Sababi:
        }                                               // Program classda e'lon qilib bo'lmagani)

       //property
        public string Title { get; set; }   
        public Book(string Title)
        {
            this.Title = Title;                        //Constructor
        } 
        public int ShowPrice()                          
        {
            return price;                               // Propertyga o'xshadi ko'proq, lekin private o'zgaruvchini method bilan Program.cs ga ko'rsatdim 
        }
     




        //props
    }
}