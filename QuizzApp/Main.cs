using QuizzApp.QuestionBuilders;

namespace QuizzApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuestionForm questionForm = new QuestionForm();
            questionForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}