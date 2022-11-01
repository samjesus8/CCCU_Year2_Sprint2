using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizzApp
{
    public partial class QuizForm : Form
    {
        
        QuestionForm Questionform = new QuestionForm();
        public QuizForm()
        {
            InitializeComponent();
            InitialiseTimer();
        }

        private void InitialiseTimer() //This must be called in order to start OR reset the timer
        {

            timerLabel.Text = Program.Timerduration;
            questionTimer.Interval = 1000; //1 Second
            questionTimer.Start();
        }

        private void QuizForm_Load(object sender, EventArgs e)
        {
            QuizBuilder.LoadQuestion(labelQuestionNum, textBoxQuestion, buttonAnswerOne, buttonAnswerTwo, buttonAnswerThree, buttonAnswerFour);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void buttonAnswerOne_Click(object sender, EventArgs e)
        {
            if (QuizBuilder.QuestionNumber != 5)
            {
                QuizBuilder.CheckAnswer(buttonAnswerOne);
                QuizBuilder.LoadQuestion(labelQuestionNum, textBoxQuestion, buttonAnswerOne, buttonAnswerTwo, buttonAnswerThree, buttonAnswerFour);
                InitialiseTimer();
            }
            else
            {
                QuizBuilder.CheckAnswer(buttonAnswerOne);
                QuizBuilder.QuestionNumber = 1;
                DialogResult DR = MessageBox.Show("Your score: " + QuizBuilder.correctCount + " out of 5.", "Results", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (QuizBuilder.correctCount > Program.HighScore) { Program.HighScore = QuizBuilder.correctCount; }
                MessageBox.Show("Current HighScore is - " + Program.HighScore);
                QuizBuilder.correctCount = 0;
                this.Visible = false;
            }

        }

        private void buttonAnswerTwo_Click(object sender, EventArgs e)
        {
            if (QuizBuilder.QuestionNumber != 5)
            {
                QuizBuilder.CheckAnswer(buttonAnswerTwo);
                QuizBuilder.LoadQuestion(labelQuestionNum, textBoxQuestion, buttonAnswerOne, buttonAnswerTwo, buttonAnswerThree, buttonAnswerFour);
                InitialiseTimer();
            }
            else
            {
                QuizBuilder.CheckAnswer(buttonAnswerTwo);
                QuizBuilder.QuestionNumber = 1;
                DialogResult DR = MessageBox.Show("Your score: " + QuizBuilder.correctCount + " out of 5.", "Results", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (QuizBuilder.correctCount > Program.HighScore) { Program.HighScore = QuizBuilder.correctCount; }
                MessageBox.Show("Current HighScore is - " + Program.HighScore);
                QuizBuilder.correctCount = 0;
                this.Visible = false;
            }

        }

        private void buttonAnswerThree_Click(object sender, EventArgs e)
        {
            if (QuizBuilder.QuestionNumber != 5)
            {
                QuizBuilder.CheckAnswer(buttonAnswerThree);
                QuizBuilder.LoadQuestion(labelQuestionNum, textBoxQuestion, buttonAnswerOne, buttonAnswerTwo, buttonAnswerThree, buttonAnswerFour);
                InitialiseTimer();
            }
            else
            {
                QuizBuilder.CheckAnswer(buttonAnswerThree);
                QuizBuilder.QuestionNumber = 1;
                DialogResult DR = MessageBox.Show("Your score: " + QuizBuilder.correctCount + " out of 5.", "Results", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (QuizBuilder.correctCount > Program.HighScore) { Program.HighScore = QuizBuilder.correctCount; }
                MessageBox.Show("Current HighScore is - " + Program.HighScore);
                QuizBuilder.correctCount = 0;
                this.Visible = false;

            }

        }

        private void buttonAnswerFour_Click(object sender, EventArgs e)
        {
            if (QuizBuilder.QuestionNumber != 5)
            {
                QuizBuilder.CheckAnswer(buttonAnswerFour);
                QuizBuilder.LoadQuestion(labelQuestionNum, textBoxQuestion, buttonAnswerOne, buttonAnswerTwo, buttonAnswerThree, buttonAnswerFour);
                InitialiseTimer();
            }
            else
            {
                QuizBuilder.CheckAnswer(buttonAnswerFour);
                QuizBuilder.QuestionNumber = 1;                
                DialogResult DR = MessageBox.Show("Your score: " + QuizBuilder.correctCount + " out of 5.", "Results", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (QuizBuilder.correctCount > Program.HighScore) { Program.HighScore = QuizBuilder.correctCount; }
                MessageBox.Show("Current HighScore is - " + Program.HighScore);
                QuizBuilder.correctCount = 0;
                this.Visible = false;
            }
        }

        private void questionTimer_Tick(object sender, EventArgs e)
        {
            if (int.Parse(timerLabel.Text) != 0) 
            {
                int nextValue = int.Parse(timerLabel.Text) - 1; //For every tick, remove 1 from the timer
                timerLabel.Text = nextValue.ToString(); //Update the label with the new countdown
            }
            else 
            {
                if (QuizBuilder.QuestionNumber != 5) 
                {
                    QuizBuilder.SkipQuestion(); //We dont want to check for any answers since the time ran out, so we skip
                    QuizBuilder.LoadQuestion(labelQuestionNum, textBoxQuestion, buttonAnswerOne, buttonAnswerTwo, buttonAnswerThree, buttonAnswerFour);
                    InitialiseTimer(); //Load next question and reset the timer
                }
                else 
                {
                    QuizBuilder.SkipQuestion();
                    QuizBuilder.QuestionNumber = 1;
                    DialogResult DR = MessageBox.Show("Your score: " + QuizBuilder.correctCount + " out of 5.", "Results", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (QuizBuilder.correctCount > Program.HighScore) { Program.HighScore = QuizBuilder.correctCount; }
                    MessageBox.Show("Current HighScore is - " + Program.HighScore);
                    QuizBuilder.correctCount = 0;
                    this.Visible = false;
                }
            }
        }
    }
}
