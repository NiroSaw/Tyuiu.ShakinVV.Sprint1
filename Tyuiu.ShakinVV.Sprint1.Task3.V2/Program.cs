using Tyuiu.ShakinVV.Sprint1.Task3.V2.Lib;

//Написать программу, которая запрашивает у пользователя исходные данные, выполняет указанные расчёты и печатает результат на экране.
//Расчеты:
//Объявите необходимые переменные и напишите программу вычисления стоимости покупки, состоящей из нескольких тетрадей и карандашей.
//Предполагается, что пользователь будет вводить данные о каждой составляющей покупки в отдельной строке: сначала цену, затем количество. Ответ округлите до 3 знаков после запятой.

namespace Tyuiu.ShakinVV.Sprint1.Task3.V2
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
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Шакин Владимир Вячеславович | АСОиУб-26-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double priceNotebook;
            Console.WriteLine("Введите цену тетради:");
            if (double.TryParse(Console.ReadLine(), out priceNotebook))
            {
                //Если введенно число
            }
            else
            {
                Console.WriteLine("Ошибка: введено не число!");
                Console.ReadLine();
                return;
            }
            int amountNotebook;
            Console.WriteLine("Введите кол-во купленных тетрадей:");
            if (int.TryParse(Console.ReadLine(), out amountNotebook))
            {
                //Если введенно число
            }
            else
            {
                Console.WriteLine("Ошибка: введено не число!");
                Console.ReadLine();
                return;
            }
            double pricePencil;
            Console.WriteLine("Введите цену карандаша:");
            if (double.TryParse(Console.ReadLine(), out pricePencil))
            {
                //Если введенно число
            }
            else
            {
                Console.WriteLine("Ошибка: введено не число!");
                Console.ReadLine();
                return;
            }
            int amountPencil;
            Console.WriteLine("Введите кол-во купленных карандашов:");
            if (int.TryParse(Console.ReadLine(), out amountPencil))
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

            Console.WriteLine("Всего потрачено = " + ds.PurchaseAmount(priceNotebook, amountNotebook, pricePencil, amountPencil));

            Console.ReadLine();
        }
    }
}
