using System;
using System.Linq;
//Задание 2
//Требуется описать структуру с именем Worker, содержащую следующие поля:  
//•  фамилия и инициалы работника;  
//•  название занимаемой должности;  
//•  год поступления на работу.  
//Написать программу, выполняющую следующие действия:  
//•  ввод с клавиатуры данных в массив, состоящий из пяти элементов типа Worker (записи должны 
//быть упорядочены по алфавиту);  
//•  если значение года введено не в соответствующем формате выдает исключение; 
//•  вывод на экран фамилии работника, стаж работы которого превышает введенное значение.  

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, post, tmpYear;
            int year;

            Worker[] staff= new Worker[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Введите ФИО: ");
                name = Console.ReadLine();

                Console.Write("Введите должность: ");
                post = Console.ReadLine();

                Console.Write("Год приёма: ");
                tmpYear = Console.ReadLine();

                try
                {
                    year = Convert.ToInt32(tmpYear);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Вы ввели недопустимое значение года.");
                    Console.ReadKey();
                    Console.WriteLine(e.Message);
                    year = DateTime.Now.Year;
                }

                staff[i] = new Worker(name, post, year);
                Console.WriteLine(new string('-',15));
            }
            staff = staff.OrderBy(worker => worker.Name).ToArray<Worker>();

            foreach (var item in staff)
            {
                Console.WriteLine($"{item.Name} {item.Post} {item.Year}");
            }

            Console.Write("Работающие больше: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(new string('-', 15));

            foreach (var item in staff)
            {
                if ((DateTime.Now.Year - item.Year) > y)
                    Console.WriteLine($"{item.Name} {item.Post} {item.Year}");
            }
            Console.ReadKey();
        }
    }
}
