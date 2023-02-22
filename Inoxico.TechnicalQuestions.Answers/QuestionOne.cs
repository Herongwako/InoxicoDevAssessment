
namespace Inoxico.TechnicalQuestions.Answers
{
    public class QuestionOne
    {
        /// <summary>
        /// Pass a string that contain sentances, and returns the highest number of words of a specifi sentance
        /// </summary>
        /// <param name="s"></param>
        /// <returns>int</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static int GetLongestSentance(string s)
        {
            string[] sentances = s.Split(new char[] { '.', '?', '!' }); // break down the whole string into sentances based on the specified characters 

            int maxWords = 0;
            
            foreach(string sentance in sentances)
            {
                string[] currSenWords = sentance.Split(" "); // split the whole sentance into words

                int wordsCount = currSenWords.Where(s => s.Any(Char.IsLetter)).Count(); // confirm that all words included as considered as a letter

                if (wordsCount > maxWords)
                {
                    maxWords = wordsCount;
                }
            }

            return maxWords;
        }
    }
}




