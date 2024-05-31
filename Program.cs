using System.Diagnostics;

namespace Module13_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ///Я не очень понял суть задания, и причем там был файл, но ладно, сделаю как понял - я весь текст из файла построчно добавил в лист и линкедлист
            ///к моему удивлению, линкед лист добавляет быстрее обычного листа
            string filePath = @"C:\Users\Sickle-shaped\Desktop\text1.txt";
            var listTime = ListInsert(filePath);
            Console.WriteLine("Время добавления текста в list: " +  listTime);
            var likedlistTime = LinkedListInsert(filePath);
            Console.WriteLine("Время добавления текста в linked list: " + likedlistTime);

        }

        static double ListInsert(string path)
        {
            double result = 0;
            List<string> list = new List<string>();
            if (File.Exists(path))
            {
                var stopWatch = Stopwatch.StartNew();
                using (StreamReader sr = File.OpenText(path))
                {
                    string str = "";
                    while ((str = sr.ReadLine()) != null)
                    {
                        list.Add(str);
                    }
                }
                result = stopWatch.Elapsed.TotalMilliseconds;
            }
            return result;
            
        }

        static double LinkedListInsert(string path)
        {
            double result = 0;
            LinkedList<string> list = new LinkedList<string>();
            if (File.Exists(path))
            {
                var stopWatch = Stopwatch.StartNew();
                using (StreamReader sr = File.OpenText(path))
                {
                    string str = "";
                    while ((str = sr.ReadLine()) != null)
                    {
                        list.AddLast(str);
                    }
                }
                result = stopWatch.Elapsed.TotalMilliseconds;
            }
            return result;
        }
    }
}