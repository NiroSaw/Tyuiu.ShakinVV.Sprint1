using System.ComponentModel.Design;
using Tyuiu.ShakinVV.Sprint1.Task2.V14.Lib;

//Формулировка задания: Известна температура в градусах Кельвина. Перевести температуру в градусы Цельсия.
//Что пользователь вводит? Температура в градусах Кельвина (целое число)
//Что программа печатает на экране? Температура в градусах Цельсия (целое число)

namespace Tyuiu.ShakinVV.Sprint1.Task2.V14
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
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Шакин Владимир Вячеславович | АСОиУб-26-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая конвертирует градусы по шкале Кельвина      *");
            Console.WriteLine("* в градусы по шкале Цельсия.                                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x;
            
            Console.WriteLine("Введите значение X:");
            if (int.TryParse(Console.ReadLine(),out x))
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

            Console.WriteLine("Температура в градусах Цельсия = " + ds.ConvertKelvinToCelsius(x));

            Console.ReadLine();
        }
    }
}
