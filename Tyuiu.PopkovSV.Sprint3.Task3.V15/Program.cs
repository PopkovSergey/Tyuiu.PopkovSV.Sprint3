using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PopkovSV.Sprint3.Task3.V15.Lib;

namespace Tyuiu.PopkovSV.Sprint3.Task3.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Попков С. В. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт#3                                                                *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Попков Сергей Вадимович | ИСТНб-23-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach подсчитать минимальное количество букв m,        *");
            Console.WriteLine("* находящихся на соседних позициях в строке: lrmmse mg sermmmrt           *");
            Console.WriteLine("*                                                                         *");

            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "lrmmse mg sermmmrt";
            char chr = 'm';

            Console.WriteLine("Исходная сторка =  " + value);
            Console.WriteLine("Искомый символ = " + chr);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Минимальное количество символов = " + ds.GetMinCharCount(value, chr));

            Console.ReadKey();
        }
    }
}
