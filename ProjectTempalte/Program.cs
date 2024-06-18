using System.Collections;
using System.IO.Pipes;
using System.Text.RegularExpressions;

namespace ProjectTempalte
{
    internal class Program
    {
        static void StackTask()
        {
            Console.WriteLine("Stack Task");
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
            stack.IsEmpty();
            Console.WriteLine("-------");
        }
        static void DeepLookStackTask()
        {
            Console.WriteLine("DeepLookStack Task");
            Stack<int> stack = new DeepLookStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
            Console.WriteLine("-------");
        }
        static void QueueTask()
        {
            Console.WriteLine("Queue Task");
            Console.WriteLine("Здесь пока ничего нет"); // сотрите эту строку после реализации класса Queue
                                                        // и как-то протестируйте ваш код
            Console.WriteLine("-------");
        }
        // При работе с файлами, создавайте и наполняйте их сами. Но не забывайти использовать относительные пути
        static void StringTask()
        {
            Console.WriteLine("String Task");
            List<string> lst = ReadFromFile("file.txt");
            var longestword = lst.Select(line => line.Split(" ")).SelectMany(word => word).Max(w => w.Length).ToString();
            Console.WriteLine($"{longestword}");
            Console.WriteLine($"{longestword.Length}");
            foreach (var c in lst)
                Console.WriteLine($"{c}");
            Console.WriteLine("-------");
        }
        static void RegexTask()
        {
            Console.WriteLine("Regex Task");
            Console.WriteLine("Здесь пока ничего нет"); // сотрите эту строку после выполнения условий из TODO ниже
            // TODO: написать Regex, который сумеет распознать email адрес.
            // Прочитать данные из файла и вывести количество email адресов.
            // Слов (а потенциально и адресов) в строке может быть несколько
            // Можно считать, что слова разделены пробелами
            Console.WriteLine("-------");
        }
        static void BinaryTask()
        {
            Console.WriteLine("Binary Task");
            Console.WriteLine("Здесь пока ничего нет"); // сотрите эту строку после выполнения условий из TODO ниже
            // TODO: реализовать функции чтения из бинароного файла и записи в него в Functions.cs.
            // Записать некоторое количество целых чисел в бинарный файл.
            // После прочитать этот же бинарный файл и вывести считанные значения на экран
            Console.WriteLine("-------");
        }
        static void DictionaryTask()
        {
            Console.WriteLine("Dictionary Task");
            Console.WriteLine("Здесь пока ничего нет"); // сотрите эту строку после выполнения условий из TODO ниже
            // TODO: создать Dictionary, где ключ - имя студента, а значение - лист его оценок по предметам за семестр.
            // Заполните словарь для 3-4 студентов.
            // Запросите у пользователя строку - имя студента, по которому он хочет узнать среднюю оценку.
            // Выведите результат. Вместо явных циклов используйте LINQ.
            Console.WriteLine("-------");
        }
        static void RecursionTask()
        {
            Console.WriteLine("Recursion Task");
            Console.WriteLine("Здесь пока ничего нет"); // сотрите эту строку после выполнения условий из TODO ниже
            // TODO: рекурсивно описать функцию MinDigit(int n) (находится в Functions.cs),
            // которая находит наименьшую цифру в десятичной записи неотрицательного целого числа N.
            // Например, MinDigit(27316) = 1.
            Console.WriteLine("-------");
        }
        static void Main(string[] args)
        {
            StackTask();
            DeepLookStackTask();
            QueueTask();
            StringTask();
            StringTask();
            RegexTask();
            BinaryTask();
            DictionaryTask();
            RecursionTask();
        }

        static List<string> ReadFromFile(string filePath)
        {
            string result = "";
            try
            {
                var lines = File.ReadAllLines(filePath).ToList();
                foreach (string line in lines)
                {
                    string lowlines = line.ToLower().Where(c => char.IsLetterOrDigit(c)).ToString();
                }
                return lines;
            }
            catch (Exception e)
            {
                Console.WriteLine("Произошла ошибка чтения файла" + e.Message);
            }
            return new List<string>();
        }


        static int[] ReadIntsFromBinaryFile(string path)
        {
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                int filesize = (int)reader.BaseStream.Length;
                int[] numbers = new int[filesize];
                for (int i = 0; i < filesize; i++)
                {
                    numbers[i] = reader.ReadInt32();
                }
                return numbers;
            }
        }


        void WriteIntsToBinaryFile(string path, List<int> data)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                foreach (int i in data)
                {
                    writer.Write(i);
                }
            }
        }

        int MinDigit(int n)
        {
            if (n < 10)
            {
                return n;
            }
            int mininrest = MinDigit(n / 10);
            int currdigit = n % 10;
            return Math.Min(mininrest, currdigit);
        }

    }
}
