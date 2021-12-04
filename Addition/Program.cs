using System;
//Задание: создайте проект по шаблону Console Application.  
//Создайте класс Calculator. 
//В теле класса создайте четыре метода для арифметических действий: Add – сложение, Sub – вычитание, 
//Mul – умножение, Div – деление.
//Метод деления должен делать проверку деления на ноль, если проверка не проходит, сгенерировать 
//исключение.  
//Пользователь вводит значения, над которыми хочет произвести операцию и выбрать саму операцию. 
//При возникновении ошибок должны выбрасываться исключения. 

namespace Addition
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            double? x = null;
            string op;

            Console.Write("Введите A: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите B: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите операцию: ");
            op = Console.ReadLine();

            Calculator calculator = new Calculator();


            switch (op)
            {
                case "+":
                    {
                        x = calculator.Add(a, b);
                        break;
                    }
                case "-":
                    {
                        x = calculator.Sub(a, b);
                        break;
                    }
                case "*":
                    {
                        x = calculator.Mul(a, b);
                        break;
                    }
                case "/":
                    {
                        try
                        {
                            x = calculator.Div(a, b);
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine("Обработка исключения.");
                            Console.WriteLine(e.Message);
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Вы ввели недопустимую операцию.");
                        break;
                    }
            }



            if (x != null)
                Console.WriteLine($"{a} {op} {b} = {x}");

            Console.WriteLine("Нажмите клавишу для выхода..");
            Console.ReadKey();
        }
    }
}
