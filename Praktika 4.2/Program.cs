using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    // Интерфейс "Товар"
    public interface IProduct
    {
        string GetName();      // Метод для получения имени товара
        double GetCost();      // Метод для определения стоимости товара
        int GetStock();        // Метод для определения остатка товара на складе
    }

    // Классы различных товаров
    public class Product : IProduct
    {
        private string name;
        private double price;
        private int stock;

        public Product(string name, double price, int stock)
        {
            this.name = name;
            this.price = price;
            this.stock = stock;
        }

        public string GetName()
        {
            return name;
        }

        public double GetCost()
        {
            return price;
        }

        public int GetStock()
        {
            return stock;
        }
    }

    public class Electronics : IProduct
    {
        private string name;
        private double price;
        private int stock;

        public Electronics(string name, double price, int stock)
        {
            this.name = name;
            this.price = price;
            this.stock = stock;
        }

        public string GetName()
        {
            return name;
        }

        public double GetCost()
        {
            return price;
        }

        public int GetStock()
        {
            return stock;
        }
    }

    public class Program
    {
        public static void Main()
        {
            // Создание объектов товаров
            IProduct product1 = new Product("Книга 1", 8, 12);
            IProduct product2 = new Product("Книга 2", 10.70, 12);
            IProduct product3 = new Product("Книга 3", 11.99, 11);
            IProduct product4 = new Electronics("Смартфон 1", 101, 10);
            IProduct product5 = new Electronics("Смартфон 2", 280, 21);
            IProduct product6 = new Electronics("Смартфон 3", 784, 7);

            // Вывод информации о товарах
            Console.WriteLine($"Товар: {product1.GetName()}");
            Console.WriteLine($"Стоимость: {product1.GetCost()} BYN");
            Console.WriteLine($"Остаток на складе: {product1.GetStock()} шт.");
            Console.WriteLine();
            Console.WriteLine($"Товар: {product2.GetName()}");
            Console.WriteLine($"Стоимость: {product2.GetCost()} BYN");
            Console.WriteLine($"Остаток на складе: {product2.GetStock()} шт.");
            Console.WriteLine();
            Console.WriteLine($"Товар: {product3.GetName()}");
            Console.WriteLine($"Стоимость: {product3.GetCost()} BYN");
            Console.WriteLine($"Остаток на складе: {product3.GetStock()} шт.");
            Console.WriteLine();
            Console.WriteLine($"Товар: {product4.GetName()}");
            Console.WriteLine($"Стоимость: {product4.GetCost()} BYN");
            Console.WriteLine($"Остаток на складе: {product4.GetStock()} шт.");
            Console.WriteLine();
            Console.WriteLine($"Товар: {product5.GetName()}");
            Console.WriteLine($"Стоимость: {product5.GetCost()} BYN");
            Console.WriteLine($"Остаток на складе: {product5.GetStock()} шт.");
            Console.WriteLine();
            Console.WriteLine($"Товар: {product6.GetName()}");
            Console.WriteLine($"Стоимость: {product6.GetCost()} BYN");
            Console.WriteLine($"Остаток на складе: {product6.GetStock()} шт.");
            Console.ReadLine();
        }
    }
}
