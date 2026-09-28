using Tyuiu.ShakinVV.Sprint1.Task4.V4.Lib;

//Написать программу, которая запрашивает у пользователя исходные данные, вычисляет результат по формуле и печатает его на экране.
//Ответ округлите до 3 знаков после запятой.
//Формула 1+xy/|x+2|    (1+xy)/(|x+2|)

namespace Tyuiu.ShakinVV.Sprint1.Task4.V4
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
            Console.WriteLine("* Задание #4                                                              *");
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
            double x;
            Console.WriteLine("Введите значение X:");
            if (double.TryParse(Console.ReadLine(), out x))
            {
                //Если введенно число
            }
            else
            {
                Console.WriteLine("Ошибка: введено не число!");
                Console.ReadLine();
                return;
            }
            double y;
            Console.WriteLine("Введите значение Y:");
            if (double.TryParse(Console.ReadLine(), out y))
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
            Console.WriteLine(ds.Calculate(x,y));
            Console.ReadKey();
        }
    }
}
