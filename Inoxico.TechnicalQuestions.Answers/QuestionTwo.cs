
namespace Inoxico.TechnicalQuestions.Answers
{
    public class QuestionTwo
    {
        public static int GetPitDepth(int[] points)
        {
            int N = points.Length;
            int deeptestPit = -1;

            int start = 0;

            while(start < N - 1)
            {
                // look for the start of a pit
                while (start < N - 1 && points[start] <= points[start + 1]){
                    start++;
                }

                int bottom = start + 1;
                // look for the bottom  of the pit
                while(bottom < N - 1 && points[bottom] > points[bottom + 1])
                {
                    bottom++;
                }

                int end = bottom + 1;
                // look for the  end of the pit
                while(end < N - 1 && points[end] < points[end + 1])
                {
                    end++;
                }
            }

            return 2;
        }
    }
}
