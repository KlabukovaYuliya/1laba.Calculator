using System;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ConsoleCalculator"); //вывод названия приложения
            Console.WriteLine("Note: You might want to try using '.' or ',' when counting float");//информируем пользователя о том, что можно испоьзовать числа типа float

            void Ask() //функция взаимодействия с пользователем
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;//вызывается метод, который задаёт цвет фона, на котором выводятся символы. Задаём тёмно-пурпурный цвет

                Console.Write("First number: ");//просим пользователя ввести первое число 
                float firstCount = float.Parse(Console.ReadLine());//создание переменной, где будет записываться введенное пользователем число через консоль

                Console.Write("Add +, subtract -, multiply *, divide / ");//просим пользователя выбрать одну из математических операций
                string way = Console.ReadLine();//создание переменной, которая принимает выбранный символ математической операции

                Console.Write("Second number: ");//просим пользователя ввести второе число
                float secondCount = float.Parse(Console.ReadLine());//создание переменной, где будет записываться введенное пользователем второе число через консоль


                Console.BackgroundColor = ConsoleColor.DarkRed;//вызывается метод, который задаёт цвет фона, на котором выводятся символы.Задаём тёмно-красный цвет

                switch (way)//создание case меню для взаимодействия с пользователем
                {
                    case "+"://если пользователь ввёл +
                        Console.Write("Result: ");
                        Console.WriteLine(firstCount + secondCount);//выводим результат операции сложения
                        Console.WriteLine("");//пропускаем строку

                        Ask();//вызываем метод
                        break;

                    case "-":
                        Console.Write("Result: ");
                        Console.WriteLine(firstCount - secondCount);//выводим результат операции вычитания
                        Console.WriteLine("");

                        Ask();
                        break;

                    case "*":
                        Console.Write("Result: ");
                        Console.WriteLine(firstCount * secondCount);//выводим результат операции умножения
                        Console.WriteLine("");

                        Ask();
                        break;

                    case "/":
                        Console.Write("Result: ");
                        Console.WriteLine(firstCount / secondCount);//выводим результат операции деления
                        Console.WriteLine("");

                        Ask();
                        break;

                    default:
                        Console.WriteLine("Wrong syntax!");//если пользователь ввёл что то помимо указанных знаков, выводим уведомление об ошибке

                        Ask();
                        break;
                }
            }

            Ask();
        }
    }
}
