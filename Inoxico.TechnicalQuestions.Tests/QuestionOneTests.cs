using Inoxico.TechnicalQuestions.Answers;
using Xunit;

namespace Inoxico.TechnicalQuestions.Tests
{
    public class QuestionOneTests
    {
        [Fact]
        public void ExampleTest()
        {
            var input = $"We test coders. Give us a try?";
            var input2 = $"Forget CVs..Save time . x x";

            var outcome = QuestionOne.GetLongestSentance(input);
            var outcome2 = QuestionOne.GetLongestSentance(input2);


            Assert.Equal(4, outcome);
            Assert.Equal(2, outcome2);
        }
    }
}