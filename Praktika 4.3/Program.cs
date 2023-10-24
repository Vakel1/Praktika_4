using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    // Интерфейс "Студент"
    public interface IStudent
    {
        // Метод для определения среднего балла
        double CalculateAVG();

        // Метод для получения информации о курсе
        string GetCourseInfo();
    }

    // Класс для представления студента
    public class Student : IStudent
    {
        private string name;
        private int course;
        private double[] grades;

        public Student(string name, int course, double[] grades)
        {
            this.name = name;
            this.course = course;
            this.grades = grades;
        }

        // Реализация метода для определения среднего балла
        public double CalculateAVG()
        {
            if (grades.Length == 0)
            {
                return 0.0;
            }

            double sum = 0;
            foreach (var grade in grades)
            {
                sum += grade;
            }

            return sum / grades.Length;
        }

        // Реализация метода для получения информации о курсе
        public string GetCourseInfo()
        {
            return $"{name}, учащийся {course} курса";
        }
    }

    class Program
    {
        static void Main()
        {
            // Создание объектов студентов разных курсов
            var student1 = new Student("Кононов Иван", 3, new double[] { 8.5, 7.0, 4.5 });
            var student2 = new Student("Горный Алексей", 2, new double[] { 8, 6.4, 5.8 });

            // Использование методов интерфейса для вывода информации о студентах
            Console.WriteLine(student1.GetCourseInfo());
            Console.WriteLine($"Средний балл: {student1.CalculateAVG():F2}");

            Console.WriteLine(student2.GetCourseInfo());
            Console.WriteLine($"Средний балл: {student2.CalculateAVG():F2}");
            Console.ReadLine();
        }
    }
}
