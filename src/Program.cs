using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Practic1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Выберите номер задания:");
                Console.WriteLine("1. Программа, которая принимает четыре числа и находит среднее значение между ними");
                Console.WriteLine("2. Программа - калькулятор, в которой можно выбрать действие для двух вводимых пользователем чисел:");
                Console.WriteLine("3. Программа для конвертации температуры между градусами Цельсия, Кельвина, Фаренгейта");
                Console.WriteLine("4. Программа, которая позволяет определить имя файла (с расширением) по введенному пути");
                Console.WriteLine("5. Программа для нахождения самого длинного слова в предложении");
                Console.WriteLine("6. Программа, которая может перемножить два массива значений");
                Console.WriteLine("7. Программа, которая может найти максимальное и минимальное число из пяти введенных");
                Console.WriteLine("8. Программа, которая выводит “пирамиду” из чисел из количества уровней, введенных пользователем");
                Console.WriteLine("9. Часть 2 (Полная таблица умножения)");
                Console.WriteLine("10. Часть 3 (Программа, которая выводит список папок в указанной директории, а также количество символов до указанного файла)");
                Console.WriteLine("0. Выход");
                string choice = Console.ReadLine();
                if (choice == "0") break;
                switch (choice)
                {
                    case "1":
                        Task1();
                        break;
                    case "2":
                        Task2();
                        break;
                    case "3":
                        Task3();
                        break;
                    case "4":
                        Task4();
                        break;
                    case "5":
                        Task5();
                        break;
                    case "6":
                        Task6();
                        break;
                    case "7":
                        Task7();
                        break;
                    case "8":
                        Task8();
                        break;
                    case "9":
                        Task9();
                        break;
                    case "10":
                        Task10();
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Пожалуйста, выберите еще раз.");
                        break;
                }
            }
        }
        static void Task1()
        {
            Console.Clear();
            Console.WriteLine("Задача 1: Разработайте программу, которая принимает четыре числа и находит среднее значение между ними.");

            double[] numbers = new double[4];
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Введите {i + 1}-е число: ");
                numbers[i] = Convert.ToDouble(Console.ReadLine());
            }
            double average = (numbers[0] + numbers[1] + numbers[2] + numbers[3]) / 4;
            Console.WriteLine($"Среднее значение: {average}");
            WaitForKey();
        }
        static void Task2()
        {
            Console.Clear();
            Console.WriteLine("Задача 2: Разработайте программу-калькулятор, в которой можно выбрать действие для двух вводимых пользователем чисел: a. сложение b. вычитание c. умножение d. деление e. нахождение остатка (оператор %)");
            Console.Write("Введите первое число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Какое действие выполнить?");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");
            Console.WriteLine("5. Нахождение остатка");
            int operation = Convert.ToInt32(Console.ReadLine());
            double result = 0;
            switch (operation)
            {
                case 1:
                    result = num1 + num2;
                    break;
                case 2:
                    result = num1 - num2;
                    break;
                case 3:
                    result = num1 * num2;
                    break;
                case 4:
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                        Console.WriteLine("Ошибка: Деление на ноль.");
                    break;
                case 5:
                    result = num1 % num2;
                    break;
                default:
                    Console.WriteLine("Неверный выбор операции.");
                    return;
            }
            Console.WriteLine($"Результат: {result}");
            WaitForKey();
        }
        static void Task3()
        {
            Console.Clear();
            Console.WriteLine("Задача 3: Разработайте программу для конвертации температуры между градусами Цельсия, Кельвина, Фаренгейта.");
            Console.WriteLine("Выберите шкалу вводимой температуры:");
            Console.WriteLine("1. Цельсий"); Console.WriteLine("2. Кельвин");
            Console.WriteLine("3. Фаренгейт");
            int inputScale = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите показатель температуры (градусы):"); double temperature = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Выберите тип шкалы для конвертации:");
            Console.WriteLine("1. Цельсий"); Console.WriteLine("2. Кельвин");
            Console.WriteLine("3. Фаренгейт");
            int outputScale = Convert.ToInt32(Console.ReadLine());
            double result = 0;
            if (inputScale == 1)
            {
                if (outputScale == 2)
                {
                    result = temperature + 273.15;
                }
                else if (outputScale == 3)
                {
                    result = (temperature * 9 / 5) + 32;
                }
            }
            else if (inputScale == 2)
            {
                if (outputScale == 1)
                {
                    result = temperature - 273.15;
                }
                else if (outputScale == 3)
                {
                    result = (temperature - 273.15) * 9 / 5 + 32;
                }
            }
            else if (inputScale == 3)
            {
                if (outputScale == 1)
                {
                    result = (temperature - 32) * 5 / 9;
                }
                else if (outputScale == 2)
                {
                    result = (temperature - 32) * 5 / 9 + 273.15;
                }
            }
            Console.WriteLine($"Вы выбрали: Из {inputScale} в {outputScale}"); Console.WriteLine($"Результат конвертации: {result}");
            WaitForKey();
        }
        static void Task4()
        {
            Console.Clear();
            Console.WriteLine("Задача 4: Программа, которая позволяет определить имя файла (с расширением) по введенному пути.");

            Console.Write("Введите путь к файлу: ");
            string path = Console.ReadLine();

            if (File.Exists(path))
            {
                string fileName = Path.GetFileName(path);
                Console.WriteLine($"Имя файла: {fileName}");
            }
            else
            {
                throw new FileNotFoundException("Файл не найден.");
            }

            WaitForKey();
        }
        static void Task5()
        {
            Console.Clear();
            Console.WriteLine("Задача 5: Разработайте программу для нахождения самого длинного слова в предложении.");
            Console.Write("Введите предложение: ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            string longestWord = "";
            foreach (string word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }
            Console.WriteLine($"Самое длинное слово: {longestWord}");
            WaitForKey();
        }
        static void Task6()
        {
            Console.Clear(); Console.WriteLine("Задача 6: Разработайте программу, которая может перемножить два массива значений");
            Console.WriteLine("Введите значения для первого массива через пробел:"); int[] array1 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Console.WriteLine("Введите значения для второго массива через пробел:"); int[] array2 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            if (array1.Length != array2.Length)
            {
                Console.WriteLine("Массивы должны быть одинаковой длины."); return;
            }
            int[] resultArray = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                resultArray[i] = array1[i] * array2[i];
            }
            Console.WriteLine("Результат: " + string.Join(" ", resultArray));
            WaitForKey();
        }
        static void Task7()
        {
            Console.Clear();
            Console.WriteLine("Задача 7: Разработайте программу, которая может найти максимальное и минимальное число из пяти введенных.");
            double[] numbers = new double[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Введите {i + 1}-е число: ");
                numbers[i] = Convert.ToDouble(Console.ReadLine());
            }
            double maxNumber = numbers[0];
            double minNumber = numbers[0];
            foreach (double number in numbers)
            {
                if (number > maxNumber) maxNumber = number;
                if (number < minNumber) minNumber = number;
            }
            Console.WriteLine($"Максимальное число: {maxNumber}");
            Console.WriteLine($"Минимальное число: {minNumber}");
            WaitForKey();
        }
        static void Task8()
        {
            Console.Clear();
            Console.WriteLine("Задача 8: Разработайте программу, которая выводит “пирамиду” из чисел из количества уровней, введенных пользователем.");
            Console.Write("Введите количество уровней пирамиды: ");
            int levels = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= levels; i++)
            {
                for (int j = levels; j > i; j--)
                    Console.Write(" ");

                for (int j = 1; j <= i; j++)
                    Console.Write(j + " ");

                Console.WriteLine();
            }
            WaitForKey();
        }
        static void Task9()
        {
            Console.Clear();
            Console.WriteLine("Задача 9: Напечатать полную таблицу умножения.");

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i * j,4}");
                }
                Console.WriteLine();
            }
            WaitForKey();
        }
        static void Task10()
        {
            Console.Clear();
            Console.WriteLine("Задача 10: Разработайте программу, которая выводит список папок в указанной директории, а также количество символов до указанного файла");
            try
            {
                Console.Write("Введите путь к директории: ");
                string directoryPath = Console.ReadLine();

                if (!Directory.Exists(directoryPath))
                {
                    throw new DirectoryNotFoundException("Директория не найдена.");
                }

                string[] directories = Directory.GetDirectories(directoryPath);

                if (directories.Length == 0)
                {
                    Console.WriteLine("В указанной директории нет папок.");
                }
                else
                {
                    Console.WriteLine("\nСписок папок:");
                    foreach (var dir in directories)
                    {
                        Console.WriteLine(Path.GetFileName(dir));
                    }
                }
                Console.Write("\nВведите путь к файлу для подсчета символов до него: ");
                string filePath = Console.ReadLine();
                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException("Файл не найден.");
                }
                int lastSlashIndex = filePath.LastIndexOfAny(new char[] { '/', '\\' });
                int characterCount = lastSlashIndex + 1;
                Console.WriteLine($"\nКоличество символов до файла '{Path.GetFileName(filePath)}': {characterCount}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при выполнении задачи: {ex.Message}");
            }
            finally
            {
                WaitForKey();
            }
        }
        static void WaitForKey()
        {
            Console.WriteLine("Задача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач");
            Console.ReadKey();
        }
    }
}
