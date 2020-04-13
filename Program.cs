using System;

namespace HW_11_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[]{
                new Book(Author : "Рей Брэдбери", nameBook : "451° по Фаренгейту"),
                new Book(Author : "Габриэль Гарсиа", nameBook : "Сто лет одиночества"),
                new Book(Author : "Джоан К. Роулинг", nameBook : "Гарри Поттер и философский камень"),
                new Book(Author : "Фрэнсис Скотт Фицджеральд", nameBook : "Великий Гэтсби"),
                new Book(Author : "Чак Паланик", nameBook : "Бойцовский клуб"),
                new Book(Author : "Марио Пьюзо", nameBook : "Крестный отец")
            };

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
