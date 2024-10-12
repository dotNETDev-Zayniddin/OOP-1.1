/*
Book class yozing. 
Unda propertylar va private field lar bo’lishi kerak. 
Class kitobning nomi, muallifi, narxi kabi malumotlarini o’zida ifodalashi lozim.
Kitobning nomini constructor yordamida kiriting!

*/
using System;
namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kitob nomini kiriting: ");
            string Title = Console.ReadLine();
            Book book= new Book(Title);
            System.Console.WriteLine($"{book.Title} nomli kitob {book.Author} ga tegishli va narxi {book.ShowPrice()}$ ga teng");
        }
    }
}
//Masala shartiga yaxshi tushunmadim.