using Tyuiu.ShakinVV.Sprint1.Task5.V4.Lib;

//Написать программу, которая решает следующую задачу:
//Идет k-я секунда суток. Определить, сколько полных часов (h) прошло к этому моменту (например, h=3, если k=13257).

namespace Tyuiu.ShakinVV.Sprint1.Task5.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Шакин В. В. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Шакин Владимир Вячеславович | АСОиУб-26-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int time;
            Console.WriteLine("Введите количество секунд:");
            if (int.TryParse(Console.ReadLine(), out time))
            {
                //Если введенно число
            }
            else
            {
                Console.WriteLine("Ошибка: введено не число!");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.SecondsToHours(time));
            Console.ReadKey();
        }
    }
}
