using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace modul5
{
    public class Calculator
    {
        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Деление на ноль недопустимо!");
            }
            return a / b;
        }

        public void ExecuteDivision(double a, double b)
        {
            try
            {
                double result = Divide(a, b);
                Console.WriteLine($"Результат деления: {result}");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }
        }
    }

    class Program
        {
            static async System.Threading.Tasks.Task Main()
            {
                var httpClient = new HttpClient();

                try
                {
                    // Попробуем выполнить запрос к несуществующему ресурсу
                    var response = await httpClient.GetStringAsync("http://nonexistentwebsite123456.com");

                    Console.WriteLine(response);
                }
                catch (HttpRequestException e)
                {
                    // Перехватим исключение и выведем сообщение об ошибке
                    Console.WriteLine("Произошла ошибка при попытке доступа к веб-ресурсу:");
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    // Закроем HttpClient
                    httpClient.Dispose();
                    Console.WriteLine("Программа завершилась без ошибок.");
                }
            // 2 esep
            int[] array = { 1, 2, 3, 4, 5 };

            try
            {
                // Пытаемся обратиться к элементу массива по индексу, который выходит за его пределы
                Console.WriteLine(array[10]);
            }
            catch (IndexOutOfRangeException e)
            {
                // Перехватываем исключение и выводим сообщение об ошибке
                Console.WriteLine("Ошибка: обращение к элементу массива за пределами его размера.");
                Console.WriteLine(e.Message);
            }
            finally
            {
                // Выводим сообщение о завершении обработки массива
                Console.WriteLine("Завершена обработка массива.");
            }


       
   // 3 esep
            Calculator calculator = new Calculator();

            calculator.ExecuteDivision(10, 2);  // Работает нормально
            calculator.ExecuteDivision(10, 0);  // Генерирует исключение
        }
    }

}


