using System;
using System.Linq;

//Задание 3
//Используя Visual Studio, создайте проект по шаблону Console Application.  
//Требуется описать структуру с именем Price, содержащую следующие поля:  
//•  название товара;  
//•  название магазина, в котором продается товар;  
//•  стоимость товара в гривнах.  
//Написать программу, выполняющую следующие действия:  
//•  ввод с клавиатуры данных в массив, состоящий из двух элементов типа Price (записи должны 
//быть упорядочены в алфавитном порядке по названиям магазинов);  
//•  вывод на экран информации о товарах, продающихся в магазине, название которого введено с 
//клавиатуры (если такого магазина нет, вывести исключение).  

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string product, shop;
            int cost;

            Price[] p = new Price[2];

            for (int i = 0; i < p.Length; i++)
            {
                Console.Write("Введите товар: ");
                product = Console.ReadLine();

                Console.Write("Введите магазин: ");
                shop = Console.ReadLine();

                Console.Write("Цена: ");
                cost = Convert.ToInt32(Console.ReadLine());

                p[i] = new Price(product, shop, cost);
                Console.WriteLine(new string('-', 15));
            }
            p = p.OrderBy(x => x.Shop).ToArray<Price>();


            Console.Write("Введите название магазина: ");
            shop = Console.ReadLine();

            try
            {
                bool flag = false;
                foreach (var item in p)
                {
                    if (item.Shop == shop)
                    {
                        flag = true;
                        Console.WriteLine($"{item.Product} из {item.Shop} по цене {item.Cost} грн.");
                    }
                }
                if (!flag)
                    throw new Exception("Нет такого магазина");
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();

        }
    }
}
