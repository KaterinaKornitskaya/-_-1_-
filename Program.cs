using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Задание 1
 Пользователь вводит с клавиатуры число в диапазоне от 1 до 100. 
 Если число кратно 3 (делится на 3 без остатка) нужно вывести слово Fizz. 
 Если число кратно 5 нужно вывести слово Buzz. 
 Если число кратно 3 и 5 нужно вывести Fizz Buzz. 
 Если число не кратно не 3 и 5 нужно вывести само число.
 Если пользователь ввел значение не в диапазоне от 1 до 100, требуется 
 вывести сообщение об ошибке.
*/

namespace task_1
{
    internal class Program
    {
        static int Main1(string[] args)
        {
            Console.WriteLine("Enter a digit from 1 to 100.");  // вывод в консоль сообщения для пользователя
            string number_str = Console.ReadLine();             // переменная типа string, инициализируем значением от пользователя
            int number = Convert.ToInt32(number_str);           // конвертируем полученное значение из string в int
           
            if (number < 1 || number > 100)                     // если введенное число < 1 или > 100
            {           
                Console.Error.WriteLine("Error digit!");        // выводим сообщение об ошибке
                return -1;                                      // выход из программы               
            }
            if ((number%3)==0 && (number%5==0))                 // если число кратно 3 И 5
            {
                Console.WriteLine("Fizz Buzz");                 // вывод в консоль сообщения Fizz Buzz
            }
            else if ((number % 3) == 0)                         // если число кратно 3
            {
                Console.WriteLine("Fizz");                      // вывод в консоль сообщения Fizz 
            }
            else if((number%5)==0)                              // если число кратно 5
            {
                Console.WriteLine("Buzz");                      // вывод в консоль сообщения Buzz
            }
            else                                                // в остальных случаях
            {
                Console.WriteLine(number);                      // вывод в консоль введенного числа
            }
            return 0;
        }
    }
}

/*
 Задание 2
Пользователь вводит с клавиатуры два числа. Первое 
число — это значение, второе число процент, который 
необходимо посчитать. Например, мы ввели с клавиатуры 
90 и 10. Требуется вывести на экран 10 процентов от 90. 
Результат: 9.
 */
namespace task_2
{
    internal class Program
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("Enter a digit");                // вывод сообщения для пользователя
            int number = Convert.ToInt32(Console.ReadLine());  // число, введенное пользователем
                                                               // конвертируем значение в int
            Console.WriteLine("Enter a percent");              // вывод сообщения для пользователя
            double percent =                                   // процент, введенный пользователем
                (Convert.ToDouble(Console.ReadLine()))/100;    // конвертируем в double и делим на 100
            double res = number*percent;                       // результат 
            Console.WriteLine("Result = " + res);              // вывод на экран результата
        }
    }
}

/*
Пользователь вводит с клавиатуры четыре цифры. 
Необходимо создать число, содержащее эти цифры. Например, если 
с клавиатуры введено 1, 5, 7, 8 тогда нужно 
сформировать число 1578.
 */
namespace task_3
{   
    internal class Program
    {       
        static void Main3(string[] args)
        {          
            Console.WriteLine("Enter a 1st digit");           // вывод в консоль сообщения
            int dig_1 = Convert.ToInt32(Console.ReadLine());  // ввод цифры 1, конвертируем в инт
            Console.WriteLine("Enter a 2nd digit");           // вывод в консоль сообщения
            int dig_2 = Convert.ToInt32(Console.ReadLine());  // ввод цифры 2, конвертируем в инт
            Console.WriteLine("Enter a 3rd digit");           // вывод в консоль сообщения
            int dig_3 = Convert.ToInt32(Console.ReadLine());  // ввод цифры 3, конвертируем в инт
            Console.WriteLine("Enter a 4th digit");           // вывод в консоль сообщения
            int dig_4 = Convert.ToInt32(Console.ReadLine());  // ввод цифры 4, конвертируем в инт

            int num = (dig_1*1000)+(dig_2*100)+(dig_3*10)+dig_4;  // полученное число
            Console.WriteLine(num);                               // вывод числа в консоль
        }
    }
}

/*
 Задание 4
Пользователь вводит шестизначное число. После чего 
пользователь вводит номера разрядов для обмена цифр. 
Например, если пользователь ввёл один и шесть — это 
значит, что надо обменять местами первую и шестую 
цифры.
Число 723895 должно превратиться в 523897.
Если пользователь ввел не шестизначное число требуется вывести 
сообщение об ошибке.
 */
namespace task_4
{
    internal class Program
    {
        static void Main4(string[] args)
        {
            Console.WriteLine("Enter a number");                  // вывод в консоль сообщения
            int number = Convert.ToInt32(Console.ReadLine());     // ввод числа, конвертируем в инт

            Console.WriteLine("Enter a number 1 to replace: ");   // вывод в консоль сообщения
            int r1 = Convert.ToInt32(Console.ReadLine());         // цифра для замены 1
            Console.WriteLine("Enter a number 2 to replace: ");   // вывод в консоль сообщения
            int r2 = Convert.ToInt32(Console.ReadLine());         // цифра для замены 1

            StringBuilder str = new StringBuilder().Append(number);  // число как string 

            char temp1 = str[r1-1];  // временная переменная для замены1
            char temp2 = str[r2-1];  // временная переменная для замены1

            str[r1-1] = temp2;  // замена местами символов
            str[r2-1] = temp1;  // замена местами символов

            string st = str.ToString();    // конвертируем в стринг
            number = Convert.ToInt32(st);  // результат конвертирует в int
            Console.WriteLine();
            Console.WriteLine(number);
        }
    }
}


/*
 Задание 5
Пользователь вводит с клавиатуры дату. Приложение должно отобразить 
название сезона и дня недели. 
Например, если введено 22.12.2021, приложение должно 
отобразить Winter Wednesday
*/
namespace task_5
{
    internal class Program
    {
        static void Main5(string[] args)
        {
            Console.WriteLine("Enter the date: day, month, year");  // вывод в консоль сообщения
            int day = Convert.ToInt32(Console.ReadLine());          // ввод день, конвертиция в int
            int month = Convert.ToInt32(Console.ReadLine());        // ввод месяц, конвертиция в int
            int year = Convert.ToInt32(Console.ReadLine());         // ввод год, конвертиция в int

            DateTime date = new DateTime(year, month, day);  // объект класса DateTime
                                                             // нужен для работы метода DayOfWeek

            // в зависимости от месяца выводим сезон и применяем метод DayOfWeek:
            if (month >=3 && month <= 5)
                Console.WriteLine("Spring, "+ date.DayOfWeek);
            else if(month >=6 && month <= 8)
                Console.WriteLine("Summer, "+ date.DayOfWeek);
            else if (month >=9 && month <= 11)
                Console.WriteLine("Autumn, "+ date.DayOfWeek);
            else 
                Console.WriteLine("Winter, "+ date.DayOfWeek);
        }
    }
}


/*
 Задание 6
Пользователь вводит с клавиатуры показания температуры. 
В зависимости от выбора пользователя программа переводит температуру 
из Фаренгейта в Цельсий 
или наоборот.
 */
namespace task_6
{
    internal class Program
    {
        static void Main6(string[] args)
        {
            Console.WriteLine("Enter temperature: ");            // вывод в консоль сообщения
            double temp = Convert.ToDouble(Console.ReadLine());  // ввод температуры, конвертация в double

            Console.WriteLine("Enter 1 to modify to F: ");       // вывод в консоль сообщения
            Console.WriteLine("Enter 2 to modify to C: ");       // вывод в консоль сообщения
            int choice = Convert.ToInt32(Console.ReadLine());    // ввод варианта, конвертация в int

            // в зависимости от выбора применяем формулу и выводим в консоль:
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Res in F: "+ ( temp*1,8 + 32));
                    break;
                case 2:
                    Console.WriteLine("Res in C: "+ ((temp-32)*5/9));
                    break;
            }
        }
    }
}


/*
 * Пользователь вводит с клавиатуры два числа. Нужно 
показать все четные числа в указанном диапазоне. Если 
границы диапазона указаны неправильно требуется произвести нормализацию
границ. Например, пользователь 
ввел 20 и 11, требуется нормализация, после которой 
начало диапазона станет равно 11, а конец 20.
 */
namespace task_7
{
    internal class Program
    {
        static void Main7(string[] args)
        {
            Console.WriteLine("Enter start: ");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter end: ");
            int end = Convert.ToInt32(Console.ReadLine());

            if (start > end)         
            {                       
                int temp = start;
                start = end;
                end = temp;
            }

            int size = end - start + 1;
            int[] arr = new int[size];                
           

            // заполняем массив, увеличивая начальное значение
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = start;
                start++;
            } 

            Console.WriteLine("Even numbers: ");
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] % 2 == 0)
                {
                    Console.Write(arr[i] + " ");   
                }

            Console.WriteLine();
        }
       
    }
}


namespace task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");                  // вывод в консоль сообщения
            int number = Convert.ToInt32(Console.ReadLine());     // ввод числа, конвертируем в инт
           
            Console.WriteLine("Enter a number 1 to replace: ");   // вывод в консоль сообщения
            int r1 = Convert.ToInt32(Console.ReadLine());         // цифра для замены 1
            Console.WriteLine("Enter a number 2 to replace: ");   // вывод в консоль сообщения
            int r2 = Convert.ToInt32(Console.ReadLine());         // цифра для замены 1

            int n1, n2, n3, n4, n5, n6;
            n6 = number - ((number / 10) * 10);
            n5 = (number / 10) - ((number / 100) * 10);
            n4 = (number / 100) - ((number / 1000) * 10);
            n3 = (number / 1000) - ((number / 10000) * 10);
            n2 = (number / 10000) - ((number / 100000) * 10);
            n1 = number / 100000;

            int[] arr = {n1, n2, n3 , n4, n5, n6};
            int i = 0;
            int num = 0;
            for (i = 0; i < 6; i++)
            {


                int temp = arr[r1 - 1];
                int temp3 = arr[r2 - 1];
                arr[r1 - 1] = temp3;
                arr[r2 - 1] = temp;
                Console.Write(arr[i]);

                num
                    = (arr[0]*100000)+(arr[1]*10000)+(arr[2]*1000)+(arr[3]*100)+(arr[4]*10)+(arr[5]);
               // Console.WriteLine(num);
                
            }
            num = Convert.ToInt32(num);
           // Console.WriteLine(num);
            //Console.WriteLine(arr[i]);

            //StringBuilder str = new StringBuilder().Append(number);  // число как string 
            //
            ///char temp1 = str[r1-1];  // временная переменная для замены1
            ///char temp2 = str[r2-1];  // временная переменная для замены1
            ///
            ///str[r1-1] = temp2;  // замена местами символов
            ///str[r2-1] = temp1;  // замена местами символов
            //
            //string st = str.ToString();    // конвертируем в стринг
            //number = Convert.ToInt32(st);  // результат конвертирует в int
            //Console.WriteLine();
            //Console.WriteLine(number);
        }
    }
}


