using System;
using System.Collections.Generic;

namespace _1
{
    // Интерфейс "Фигура"
    public interface IShape
    {
        double CalculateArea();     // Метод для вычисления площади
        double CalculatePerimeter(); // Метод для вычисления периметра
    }

    // Класс Круг, реализующий интерфейс "Фигура"
    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }

    // Класс Прямоугольник, реализующий интерфейс "Фигура"
    public class Rectangle : IShape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double CalculateArea()
        {
            return length * width;
        }

        public double CalculatePerimeter()
        {
            return 2 * (length + width);
        }
    }

    // Класс Треугольник, реализующий интерфейс "Фигура"
    // Класс Треугольник, реализующий интерфейс "Фигура"
    public class Triangle : IShape
    {
        private double side1;
        private double side2;
        private double side3;

        public Triangle(double side1, double side2, double side3)
        {
            if (IsValidTriangle(side1, side2, side3))
            {
                this.side1 = side1;
                this.side2 = side2;
                this.side3 = side3;
            }
            else
            {
                throw new ArgumentException("Неверные значения сторон треугольника. Условие суммы двух сторон больше третьей не выполняется.");
            }
        }

        public double CalculateArea()
        {
            double s = (side1 + side2 + side3) / 2;
            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }

        public double CalculatePerimeter()
        {
            return side1 + side2 + side3;
        }

        // Проверка условия суммы двух сторон больше третьей
        private bool IsValidTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }

   
        class Program
        {
            static void Main(string[] args)
            {
                bool continueCalculations = true;
                while (continueCalculations)
                {
                    Console.WriteLine("Выберите фигуру: ");
                    Console.WriteLine("1. Круг");
                    Console.WriteLine("2. Прямоугольник");
                    Console.WriteLine("3. Треугольник");
                    Console.WriteLine("4. Выйти");

                    int choice;
                    if (!int.TryParse(Console.ReadLine(), out choice))
                    {
                        Console.WriteLine("Некорректный ввод. Пожалуйста, введите число от 1 до 4.");
                        continue;
                    }

                    switch (choice)
                    {
                        case 1:
                            Console.Write("Введите радиус круга: ");
                            double radius;
                            if (!double.TryParse(Console.ReadLine(), out radius) || radius < 0)
                            {
                                Console.WriteLine("Неверный ввод для радиуса. Введите положительное число.");
                            }
                            else
                            {
                                try
                                {
                                    Circle circle = new Circle(radius);
                                    Console.WriteLine("Площадь круга: " + circle.CalculateArea());
                                    Console.WriteLine("Периметр круга: " + circle.CalculatePerimeter());
                                }
                                catch (ArgumentException ex)
                                {
                                    Console.WriteLine("Ошибка: " + ex.Message);
                                }
                            }
                            break;

                        case 2:
                            Console.Write("Введите длину прямоугольника: ");
                            double length;
                            if (!double.TryParse(Console.ReadLine(), out length) || length < 0)
                            {
                                Console.WriteLine("Неверный ввод для длины. Введите положительное число.");
                                continue;
                            }

                            Console.Write("Введите ширину прямоугольника: ");
                            double width;
                            if (!double.TryParse(Console.ReadLine(), out width) || width < 0)
                            {
                                Console.WriteLine("Неверный ввод для ширины. Введите положительное число.");
                            }
                            else
                            {
                                try
                                {
                                    Rectangle rectangle = new Rectangle(length, width);
                                    Console.WriteLine("Площадь прямоугольника: " + rectangle.CalculateArea());
                                    Console.WriteLine("Периметр прямоугольника: " + rectangle.CalculatePerimeter());
                                }
                                catch (ArgumentException ex)
                                {
                                    Console.WriteLine("Ошибка: " + ex.Message);
                                }
                            }
                            break;

                        case 3:
                            Console.Write("Введите длину первой стороны треугольника: ");
                            double side1;
                            if (!double.TryParse(Console.ReadLine(), out side1) || side1 < 0)
                            {
                                Console.WriteLine("Неверный ввод для первой стороны. Введите положительное число.");
                                continue;
                            }

                            Console.Write("Введите длину второй стороны треугольника: ");
                            double side2;
                            if (!double.TryParse(Console.ReadLine(), out side2) || side2 < 0)
                            {
                                Console.WriteLine("Неверный ввод для второй стороны. Введите положительное число.");
                                continue;
                            }

                            Console.Write("Введите длину третьей стороны треугольника: ");
                            double side3;
                            if (!double.TryParse(Console.ReadLine(), out side3) || side3 < 0)
                            {
                                Console.WriteLine("Неверный ввод для третьей стороны. Введите положительное число.");
                            }
                            else
                            {
                                try
                                {
                                    Triangle triangle = new Triangle(side1, side2, side3);
                                    Console.WriteLine("Площадь треугольника: " + triangle.CalculateArea());
                                    Console.WriteLine("Периметр треугольника: " + triangle.CalculatePerimeter());
                                }
                                catch (ArgumentException ex)
                                {
                                    Console.WriteLine("Ошибка: " + ex.Message);
                                }
                            }
                            break;

                        case 4:
                            continueCalculations = false;
                            break;

                        default:
                            Console.WriteLine("Неверный выбор. Пожалуйста, выберите от 1 до 4.");
                            break;
                    }
                }
            }
        }
    }

