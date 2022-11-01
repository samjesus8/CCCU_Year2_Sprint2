using QuizzApp.QuestionBuilders;
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
    public partial class QuestionForm : Form
    {
        public QuestionForm()
        {
            InitializeComponent();
        }

        public QuestionBuilder QB { get; set; }

        //THIS IS JUST A TEST FORM. WHOEVER IS DOING THE UI CAN CHANGE IT
        //THIS FORM WAS CREATED TO TEST THE JSON FILE AND SEE IF IT READS WELL

        //var generalBuilder = new QuestionBuilder("General");
        //string message = "Question:" + generalBuilder.Question + "\r\n" +
        //                 "Correct: " + generalBuilder.CorrectAnswer + "\r\n" +
        //                 "I1: " + generalBuilder.Incorrect1 + "\r\n" +
        //                 "I2: " + generalBuilder.Incorrect2 + "\r\n" +
        //                 "I3: " + generalBuilder.Incorrect3 + "\r\n";
        //
        //outputBox.Text = message;

        private void generalButton_Click(object sender, EventArgs e)
        {
            List<QuestionBuilder> QL = new List<QuestionBuilder>();
            bool loop = true;
            bool AddQuestion = false;

            musicButton.Visible = false;
            generalButton.Visible = false;
            filmsButton.Visible = false;
            animalsButton.Visible = false;

            for (int i = 0; i < 5; i++)
            {
                QB = new QuestionBuilder("General");
                loop = true;

                while (loop == true)
                {
                    if (QL.Count == 0)
                    {
                        QL.Add(QB);
                        loop = false;
                    }
                    else
                    {
                        foreach (QuestionBuilder q in QL)
                        {
                            if (q.Question == QB.Question)
                            {
                                QB = new QuestionBuilder("General");
                                loop = true;
                            }
                            else
                            {
                                string temp = QB.Question;
                                AddQuestion = true;
                                loop = false;
                            }
                        }
                    }
                }

                if (AddQuestion == true) { QL.Add(QB); }
            }


            QuizBuilder.LoadQuestionForm(QL);

        }
         
        private void musicButton_Click(object sender, EventArgs e)
        {
            List<QuestionBuilder> QL = new List<QuestionBuilder>();
            bool loop = true;
            bool AddQuestion = false;

            musicButton.Visible = false;
            generalButton.Visible = false;
            filmsButton.Visible = false;
            animalsButton.Visible = false;

            for (int i = 0; i < 5; i++)
            {
                QB = new QuestionBuilder("Music");
                loop = true;

                while (loop == true)
                {
                    if (QL.Count == 0)
                    {
                        QL.Add(QB);
                        loop = false;
                    }
                    else
                    {
                        foreach (QuestionBuilder q in QL)
                        {
                            if (q.Question == QB.Question)
                            {
                                QB = new QuestionBuilder("Music");
                                loop = true;
                            }
                            else
                            {
                                string temp = QB.Question;
                                AddQuestion = true;
                                loop = false;
                            }
                        }
                    }
                }

                if (AddQuestion == true) { QL.Add(QB); }
            }


            QuizBuilder.LoadQuestionForm(QL);
        }

        private void filmsButton_Click(object sender, EventArgs e)
        {
            List<QuestionBuilder> QL = new List<QuestionBuilder>();
            bool loop = true;
            bool AddQuestion = false;

            musicButton.Visible = false;
            generalButton.Visible = false;
            filmsButton.Visible = false;
            animalsButton.Visible = false;

            for (int i = 0; i < 5; i++)
            {
                QB = new QuestionBuilder("Films");
                loop = true;

                while (loop == true)
                {
                    if (QL.Count == 0)
                    {
                        QL.Add(QB);
                        loop = false;
                    }
                    else
                    {
                        foreach (QuestionBuilder q in QL)
                        {
                            if (q.Question == QB.Question)
                            {
                                QB = new QuestionBuilder("Films");
                                loop = true;
                            }
                            else
                            {
                                string temp = QB.Question;
                                AddQuestion = true;
                                loop = false;
                            }
                        }
                    }
                }

                if (AddQuestion == true) { QL.Add(QB); }
            }


            QuizBuilder.LoadQuestionForm(QL);
        }

        private void animalsButton_Click(object sender, EventArgs e)
        {
            List<QuestionBuilder> QL = new List<QuestionBuilder>();
            bool loop = true;
            bool AddQuestion = false;

            musicButton.Visible = false;
            generalButton.Visible = false;
            filmsButton.Visible = false;
            animalsButton.Visible = false;

            for (int i = 0; i < 5; i++)
            {
                QB = new QuestionBuilder("Animals");
                loop = true;

                while (loop == true)
                {
                    if (QL.Count == 0)
                    {
                        QL.Add(QB);
                        loop = false;
                    }
                    else
                    {
                        foreach (QuestionBuilder q in QL)
                        {
                            if (q.Question == QB.Question)
                            {
                                QB = new QuestionBuilder("Animals");
                                loop = true;
                            }
                            else
                            {
                                string temp = QB.Question;
                                AddQuestion = true;
                                loop = false;
                            }
                        }
                    }
                }

                if (AddQuestion == true) { QL.Add(QB); }
            }


            QuizBuilder.LoadQuestionForm(QL);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Program.Timerduration = "20";
            musicButton.Visible = true;
            generalButton.Visible = true;
            filmsButton.Visible = true;
            animalsButton.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.Timerduration = "10";
            musicButton.Visible = true;
            generalButton.Visible = true;
            filmsButton.Visible = true;
            animalsButton.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.Timerduration = "2";
            musicButton.Visible = true;
            generalButton.Visible = true;
            filmsButton.Visible = true;
            animalsButton.Visible = true;
        }
        private void QuestionForm_Load(object sender, EventArgs e)
        {
            musicButton.Visible = false;
            generalButton.Visible = false;
            filmsButton.Visible = false;
            animalsButton.Visible = false;
            
        }
    }
}
