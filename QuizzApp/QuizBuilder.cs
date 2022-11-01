using QuizzApp.QuestionBuilders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace QuizzApp
{
    internal static class QuizBuilder
    {
        public static Random rng = new Random();
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static int QuestionNumber = 1;
        public static int correctCount = 0;
        public static string rightAnswer;        

        public static List<QuestionBuilders.QuestionBuilder> QuestionList = new List<QuestionBuilders.QuestionBuilder>();

       

        public static void LoadQuestionForm(List<QuestionBuilders.QuestionBuilder> QL)
        {
            QuizForm QF = new QuizForm();
            QuestionList = QL;
            QuestionList = QuestionList.OrderBy(a => Guid.NewGuid()).ToList();
            QF.Visible = true;
        }

        public static void LoadQuestion(Label QuestionNumberLabel, TextBox QuestionLabel, Button button1, Button button2, Button button3, Button button4)
        {
            QuestionBuilders.QuestionBuilder CurrentQuestion = QuestionList[QuestionNumber - 1];
            QuestionNumberLabel.Text = "Q: " + QuestionNumber + " / 5";
            QuestionLabel.Text = CurrentQuestion.Question;

            List<string> Answer = new List<string>();

            Answer.Add(CurrentQuestion.CorrectAnswer);
            Answer.Add(CurrentQuestion.Incorrect1);
            Answer.Add(CurrentQuestion.Incorrect2);
            Answer.Add(CurrentQuestion.Incorrect3);

            rightAnswer = CurrentQuestion.CorrectAnswer;

            var ShuffledAnswers = Answer.OrderBy(a => Guid.NewGuid()).ToList();

            button1.Text = ShuffledAnswers[0];
            button2.Text = ShuffledAnswers[1];
            button3.Text = ShuffledAnswers[2];
            button4.Text = ShuffledAnswers[3];


        }

        /// <summary>
        /// method to check the selected answer is correct
        /// adds to question counter and correct answer
        /// Loads next question
        /// </summary>
        /// <param name="button"></param>
        public static void CheckAnswer(Button button)
        {
            string b = button.Text;

            if (b == rightAnswer)
            {
                correctCount = correctCount + 1;
                QuestionNumber = QuestionNumber + 1;

            }
            else if (b != rightAnswer)
            {
                QuestionNumber = QuestionNumber + 1;
            }
        }

        public static void SkipQuestion() 
        {
            QuestionNumber = QuestionNumber + 1;
        }
    }
}
