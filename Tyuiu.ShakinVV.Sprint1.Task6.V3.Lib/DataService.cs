using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShakinVV.Sprint1.Task6.V3.Lib
{
    public class DataService : ISprint1Task6V3
    {
        public string LastLetterWord(string value)
        {
            string message = "";

            string[] words = value.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                message += word[word.Length - 1];
            }
            return message;
        }
    }
}
