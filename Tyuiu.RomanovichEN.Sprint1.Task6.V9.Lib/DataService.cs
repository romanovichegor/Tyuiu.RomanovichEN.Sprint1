using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.RomanovichEN.Sprint1.Task6.V9.Lib
{
    public class DataService : ISprint1Task6V9
    {
        public string MoveLetterToStart(string value)
        {
            {
                string[] words = value.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                List<string> processedWords = new List<string>();
                foreach (string word in words)
                {
                    if (word.Length > 0)
                    {
                        char lastChar = word[word.Length - 1];
                        string newWord = lastChar + word.Substring(0, word.Length - 1);
                        processedWords.Add(newWord);
                    }
                }
                return string.Join(" ", processedWords);
            }
        }
    }
}