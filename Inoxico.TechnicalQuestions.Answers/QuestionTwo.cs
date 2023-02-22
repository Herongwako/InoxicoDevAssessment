
namespace Inoxico.TechnicalQuestions.Answers
{
    public class QuestionTwo
    {
        /// <summary>
        /// Get a pit depth by passing an array
        /// </summary>
        /// <param name="points"></param>
        /// <returns>int</returns>
        public static int GetPitDepth(int[] points)
        {
            try
            {
                int N = points.Length - 1;
                int deepestPit = -1;

                int start = 0;

                while (start < N)
                {
                    // look for the start of a pit
                    while (start < N && points[start] <= points[start + 1])
                    {
                        start++;
                    }

                    int bottom = start + 1;
                    // look for the bottom  of the pit
                    while (bottom < N && points[bottom] > points[bottom + 1])
                    {
                        bottom++;
                    }

                    int end = bottom + 1;
                    // look for the  end of the pit
                    while (end < N && points[end] < points[end + 1])
                    {
                        end++;
                    }

                    int depth = Math.Min(points[start] - points[bottom], points[end] - points[bottom]); //The depth of a pit (P, Q, R)
                    if (depth > deepestPit)
                    {
                        deepestPit = depth;
                    }

                    start = end; //update using the last pit
                }
                return deepestPit;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }
    }
}
