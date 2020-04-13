using System;

namespace HW_11_04
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Book{
        public string Author{get;set;}
        public string nameBook{get;set;}

        public Book(string Author, string nameBook){
            this.Author = Author;
            this.nameBook = nameBook;

        }
        

        public void showBooks(){
            System.Console.WriteLine("Author: " +Author);
            System.Console.WriteLine("Book: "+nameBook);

        }
    }


    
}
