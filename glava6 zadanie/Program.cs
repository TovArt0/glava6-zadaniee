using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glava6_zadanie
{
    class SymbolInfo
    {
        private char symbol;
        public void SetSymbol(char newSymbol)
        {
            symbol = newSymbol;
        }
        public int GetSymbolCode()
        {
            return (int)symbol;
        }
        public void PrintSymbolAndCode()
        {
            Console.WriteLine($"Символ: {symbol}, Код символа: {GetSymbolCode()}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SymbolInfo symbolInfo = new SymbolInfo();
            //Присваиваем значение полю
            symbolInfo.SetSymbol('A');
            //Получаем код символа и выводим его
            Console.WriteLine($"Код символа: {symbolInfo.GetSymbolCode()}");
            //Выводим символ и его код
            symbolInfo.PrintSymbolAndCode();
        }
    }


    class CharacterRangePrinter
    {
        private char startChar;
        private char endChar;
        public void SetRange(char start, char end)
        {
            startChar = start;
            endChar = end;
        }
        public void PrintRange()
        {
            if (startChar > endChar)
            {
                Console.WriteLine("Ошибка: начальный символ должен быть меньше или равен конечному символу.");
                return;
            }
            Console.WriteLine($"Символы в диапазоне от '{startChar}' до '{endChar}':");
            for (char c = startChar; c <= endChar; c++)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CharacterRangePrinter rangePrinter = new CharacterRangePrinter();
            // Устанавливаем диапазон символов
            rangePrinter.SetRange('A', 'D');
            // Выводим символы в указанном диапазоне
            rangePrinter.PrintRange();
        }
    }



    class MyClass
    {
        private int number1;
        private int number2;
        // Конструктор без аргументов
        public MyClass()
        {
            number1 = 0;
            number2 = 0;
        }
        // Конструктор с одним аргументом
        public MyClass(int num)
        {
            number1 = num;
            number2 = num;
        }
        // Конструктор с двумя аргументами
        public MyClass(int num1, int num2)
        {
            number1 = num1;
            number2 = num2;
        }
        // Метод для вывода значений полей
        public void ShowNumbers()
        {
            Console.WriteLine($"Значение поля number1: {number1}");
            Console.WriteLine($"Значение поля number2: {number2}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Создание объектов с использованием различных конструкторов
            MyClass obj1 = new MyClass();
            MyClass obj2 = new MyClass(10);
            MyClass obj3 = new MyClass(20, 30);
            // Вывод значений полей для каждого объекта
            Console.WriteLine("Объект 1:");
            obj1.ShowNumbers();
            Console.WriteLine();
            Console.WriteLine("Объект 2:");
            obj2.ShowNumbers();
            Console.WriteLine();
            Console.WriteLine("Объект 3:");
            obj3.ShowNumbers();
        }
    }




    class MyClass
    {
        private int integerValue;
        private char charValue;
        // Конструктор с двумя аргументами (целое число и символ)
        public MyClass(int intValue, char charValue)
        {
            this.integerValue = intValue;
            this.charValue = charValue;
        }
        // Конструктор с одним аргументом типа double
        public MyClass(double doubleValue)
        {
            int intValue = (int)doubleValue;
            char charValue = (char)(doubleValue - intValue + '0');

            this.integerValue = intValue;
            this.charValue = charValue;
        }
        // Метод для вывода значений полей
        public void ShowValues()
        {
            Console.WriteLine($"Символьное поле: {charValue}, Целочисленное поле: {integerValue}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта с двумя аргументами
            MyClass obj1 = new MyClass(65, 'A');
            Console.WriteLine("Объект 1:");
            obj1.ShowValues();
            Console.WriteLine();
            // Создание объекта с одним аргументом типа double
            double doubleArgument = 65.1267;
            MyClass obj2 = new MyClass(doubleArgument);
            Console.WriteLine("Объект 2:");
            obj2.ShowValues();
        }
    }








    class MinMaxValues
    {
        private int min;
        private int max;
        // Конструктор, работающий по тому же принципу, что и метод для присваивания значений полям.
        public MinMaxValues(int value1, int value2)
        {
            AssignValues(value1, value2);
        }
        // Метод для присваивания значений полям объекта.
        public void AssignValues(int value1, int value2)
        {
            min = Math.Min(value1, value2);
            max = Math.Max(value1, value2);
        }
        // Метод для отображения значений полей объекта.
        public void DisplayValues()
        {
            Console.WriteLine($"Минимальное значение: {min}");
            Console.WriteLine($"Максимальное значение: {max}");
        }
    }

    class Program
    {
        static void Main()
        {
            // Создание объекта с использованием конструктора.
            MinMaxValues obj1 = new MinMaxValues(10, 5);
            obj1.DisplayValues();
            // Изменение значений полей объекта с использованием метода.
            obj1.AssignValues(7, 15);
            obj1.DisplayValues();
            // Создание объекта без использования конструктора.
            MinMaxValues obj2 = new MinMaxValues(20, 25);
            obj2.DisplayValues();
        }
    }






    class MyClass
    {
        private char symbolField;
        private string textField;
        // Перегруженный метод для присвоения значений полям
        public void SetValue(char value)
        {
            symbolField = value;
        }
        public void SetValue(string value)
        {
            textField = value;
        }
        public void SetValue(char[] value)
        {
            if (value.Length == 1)
            {
                symbolField = value[0];
            }
            else
            {
                textField = new string(value);
            }
        }
        // Метод для отображения значений полей
        public void ShowFields()
        {
            Console.WriteLine($"Символьное поле: {symbolField}");
            Console.WriteLine($"Текстовое поле: {textField}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.SetValue('A');
            obj.ShowFields();
            obj.SetValue("Hello");
            obj.ShowFields();
            char[] charArray = { 'T', 'e', 's', 't' };
            obj.SetValue(charArray);
            obj.ShowFields();
        }
    }






    class MyClass
    {
        private static int staticField = 0;
        // Статический метод для отображения текущего значения и увеличения статического поля
        public static void Display()
        {
            Console.WriteLine("Текущее значение статического поля: " + staticField);
            staticField++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Вызываем статический метод класса MyClass для отображения текущего значения статического поля и его увеличения
            MyClass.Display();
            MyClass.Display();
            MyClass.Display();
        }
    }









    class MathOperations
    {
        // Статический метод для нахождения наибольшего значения
        public static int FindMax(params int[] numbers)
        {
            if (numbers.Length == 0)
                throw new ArgumentException("Массив чисел пуст.", nameof(numbers));
            int max = numbers[0];
            foreach (int num in numbers)
            {
                if (num > max)
                    max = num;
            }
            return max;
        }


        // Статический метод для нахождения наименьшего значения
        public static int FindMin(params int[] numbers)
        {
            if (numbers.Length == 0)
                throw new ArgumentException("Массив чисел пуст.", nameof(numbers));
            int min = numbers[0];
            foreach (int num in numbers)
            {
                if (num < min)
                    min = num;
            }
            return min;
        }

        // Статический метод для нахождения среднего значения
        public static double FindAverage(params int[] numbers)
        {
            if (numbers.Length == 0)
                throw new ArgumentException("Массив чисел пуст.", nameof(numbers));
            double sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum / numbers.Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            Console.WriteLine("Наибольшее значение: " + MathOperations.FindMax(numbers));
            Console.WriteLine("Наименьшее значение: " + MathOperations.FindMin(numbers));
            Console.WriteLine("Среднее значение: " + MathOperations.FindAverage(numbers));
        }
    }




}