using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    // Интерфейс "Книга"
    public interface IBook
    {
        // Метод для проверки доступности книги
        string IsAvailable();

        // Метод для выдачи книги
        void Borrow();
    }

    // Класс для представления книги
    public class Book : IBook
    {
        private string title;
        private string author;
        private bool isBorrowed;

        public string Title // Добавлено свойство Title
        {
            get { return title; }
        }

        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
            this.isBorrowed = false;
        }

        // Реализация метода для проверки доступности книги
        public string IsAvailable()
        {
            return isBorrowed ? "нет" : "да";
        }

        // Реализация метода для выдачи книги
        public void Borrow()
        {
            if (!isBorrowed)
            {
                isBorrowed = true;
                Console.WriteLine($"Книга \"{title}\" автора {author} выдана.");
            }
            else
            {
                Console.WriteLine($"Книга \"{title}\" автора {author} уже выдана.");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            // Создание объектов книг
            var book1 = new Book("1984", "Джордж Оруэлл");
            var book2 = new Book("Война и мир", "Лев Толстой");

            // Проверка доступности и выдача книг
            Console.WriteLine($"Книга \"{book1.Title}\" доступна: {book1.IsAvailable()}");
            book1.Borrow();
            Console.WriteLine($"Книга \"{book1.Title}\" доступна: {book1.IsAvailable()}");

            Console.WriteLine($"Книга \"{book2.Title}\" доступна: {book2.IsAvailable()}");
            book2.Borrow();
            Console.WriteLine($"Книга \"{book2.Title}\" доступна: {book2.IsAvailable()}");
            Console.ReadLine();
        }
    }
}
