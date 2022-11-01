using Newtonsoft.Json;

namespace QuizzApp.QuestionBuilders
{
    public class QuestionBuilder : Form
    {
        //IMPORTANT - Please make sure to Copy and Paste the JSON file into your /bin/Debug/net6.0-windows Folder before running the program
        //ALL QUESTIONS (Members) MUST HAVE THE SAME PROPERTIES AND MUST HAVE A COMMA AT THE END OF EACH ENTRY NEXT TO THE CURLY BRACKETS
        //Look at the General Knowledge section of the JSON for an example of how you need to add your questions


        public string? Question { get; set; } //Initialising main variables
        public string? CorrectAnswer { get; set; }
        public string? Incorrect1 { get; set; }
        public string? Incorrect2 { get; set; }
        public string? Incorrect3 { get; set; }

        public List<string>? AnswerList = new List<string>();

        public QuestionBuilder(string QuestionType) //There is more than 1 category so we need an input
        {
            try 
            {
                using (StreamReader sr = new StreamReader("Questions.json")) //Open the JSON file
                {
                    string json = sr.ReadToEnd();
                    JSONObject obj = JsonConvert.DeserializeObject<JSONObject>(json); //Filters it out into its different properties

                    Random random = new Random(); //Generating the questions at random

                    if (QuestionType == "General")
                    {
                        var generalKnowledgeData = obj.generalKnowledge[random.Next(0, obj.generalKnowledge.Length)];

                        this.Question = generalKnowledgeData.Question; //Taking the properties from the JSON file and loading it into the class
                        this.CorrectAnswer = generalKnowledgeData.CorrectAnswer;
                        this.Incorrect1 = generalKnowledgeData.Incorrect1;
                        this.Incorrect2 = generalKnowledgeData.Incorrect2;
                        this.Incorrect3 = generalKnowledgeData.Incorrect3;

                    }
                    else if (QuestionType == "Animals")
                    {
                        var animalsData = obj.animals[random.Next(0, obj.animals.Length)];

                        this.Question = animalsData.Question;
                        this.CorrectAnswer = animalsData.CorrectAnswer;
                        this.Incorrect1 = animalsData.Incorrect1;
                        this.Incorrect2 = animalsData.Incorrect2;
                        this.Incorrect3 = animalsData.Incorrect3;
                    }
                    else if (QuestionType == "Films")
                    {
                        var filmsData = obj.films[random.Next(0, obj.films.Length)];

                        this.Question = filmsData.Question;
                        this.CorrectAnswer = filmsData.CorrectAnswer;
                        this.Incorrect1 = filmsData.Incorrect1;
                        this.Incorrect2 = filmsData.Incorrect2;
                        this.Incorrect3 = filmsData.Incorrect3;
                    }
                    else if (QuestionType == "Music") 
                    {
                        var musicData = obj.music[random.Next(0, obj.music.Length)];

                        this.Question = musicData.Question;
                        this.CorrectAnswer = musicData.CorrectAnswer;
                        this.Incorrect1 = musicData.Incorrect1;
                        this.Incorrect2 = musicData.Incorrect2;
                        this.Incorrect3 = musicData.Incorrect3;
                    }

                    AnswerList.Add(Incorrect1);
                    AnswerList.Add(Incorrect2);
                    AnswerList.Add(Incorrect3);
                    AnswerList.Add(CorrectAnswer);

                }
            }
            catch(Exception ex) //Catches any errors in case the formatting of the JSON goes wrong or corrupts
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }

    class JSONObject //The main structure of the JSON file
    {
        public string? Questions { get; set; }
        public GeneralKnowledge[]? generalKnowledge { get; set; }
        public Animals[]? animals { get; set; }
        public Films[]? films { get; set; }
        public Music[]? music { get; set; }
        
    }

    //Getting each property of each category from JSON

    class GeneralKnowledge 
    {
        public string? Question { get; set; }
        public string? CorrectAnswer { get; set; }
        public string? Incorrect1 { get; set; }
        public string? Incorrect2 { get; set; }
        public string? Incorrect3 { get; set; }
    }
    class Animals
    {
        public string? Question { get; set; }
        public string? CorrectAnswer { get; set; }
        public string? Incorrect1 { get; set; }
        public string? Incorrect2 { get; set; }
        public string? Incorrect3 { get; set; }
    }
    class Films
    {
        public string? Question { get; set; }
        public string? CorrectAnswer { get; set; }
        public string? Incorrect1 { get; set; }
        public string? Incorrect2 { get; set; }
        public string? Incorrect3 { get; set; }
    }
    class Music
    {
        public string? Question { get; set; }
        public string? CorrectAnswer { get; set; }
        public string? Incorrect1 { get; set; }
        public string? Incorrect2 { get; set; }
        public string? Incorrect3 { get; set; }
    }
}
