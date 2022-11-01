namespace QuizzApp
{
    partial class QuizForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelQuestionNum = new System.Windows.Forms.Label();
            this.buttonAnswerOne = new System.Windows.Forms.Button();
            this.buttonAnswerTwo = new System.Windows.Forms.Button();
            this.buttonAnswerThree = new System.Windows.Forms.Button();
            this.buttonAnswerFour = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.timerLabel = new System.Windows.Forms.Label();
            this.questionTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelQuestionNum
            // 
            this.labelQuestionNum.AutoSize = true;
            this.labelQuestionNum.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelQuestionNum.Location = new System.Drawing.Point(30, 18);
            this.labelQuestionNum.Name = "labelQuestionNum";
            this.labelQuestionNum.Size = new System.Drawing.Size(30, 25);
            this.labelQuestionNum.TabIndex = 0;
            this.labelQuestionNum.Text = "Q.";
            // 
            // buttonAnswerOne
            // 
            this.buttonAnswerOne.Location = new System.Drawing.Point(39, 97);
            this.buttonAnswerOne.Name = "buttonAnswerOne";
            this.buttonAnswerOne.Size = new System.Drawing.Size(283, 139);
            this.buttonAnswerOne.TabIndex = 2;
            this.buttonAnswerOne.Text = "button1";
            this.buttonAnswerOne.UseVisualStyleBackColor = true;
            this.buttonAnswerOne.Click += new System.EventHandler(this.buttonAnswerOne_Click);
            // 
            // buttonAnswerTwo
            // 
            this.buttonAnswerTwo.Location = new System.Drawing.Point(347, 97);
            this.buttonAnswerTwo.Name = "buttonAnswerTwo";
            this.buttonAnswerTwo.Size = new System.Drawing.Size(283, 139);
            this.buttonAnswerTwo.TabIndex = 3;
            this.buttonAnswerTwo.Text = "button2";
            this.buttonAnswerTwo.UseVisualStyleBackColor = true;
            this.buttonAnswerTwo.Click += new System.EventHandler(this.buttonAnswerTwo_Click);
            // 
            // buttonAnswerThree
            // 
            this.buttonAnswerThree.Location = new System.Drawing.Point(39, 258);
            this.buttonAnswerThree.Name = "buttonAnswerThree";
            this.buttonAnswerThree.Size = new System.Drawing.Size(283, 139);
            this.buttonAnswerThree.TabIndex = 4;
            this.buttonAnswerThree.Text = "button3";
            this.buttonAnswerThree.UseVisualStyleBackColor = true;
            this.buttonAnswerThree.Click += new System.EventHandler(this.buttonAnswerThree_Click);
            // 
            // buttonAnswerFour
            // 
            this.buttonAnswerFour.Location = new System.Drawing.Point(347, 258);
            this.buttonAnswerFour.Name = "buttonAnswerFour";
            this.buttonAnswerFour.Size = new System.Drawing.Size(283, 139);
            this.buttonAnswerFour.TabIndex = 5;
            this.buttonAnswerFour.Text = "button4";
            this.buttonAnswerFour.UseVisualStyleBackColor = true;
            this.buttonAnswerFour.Click += new System.EventHandler(this.buttonAnswerFour_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(582, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Location = new System.Drawing.Point(39, 46);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(591, 45);
            this.textBoxQuestion.TabIndex = 7;
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timerLabel.Location = new System.Drawing.Point(12, 401);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(0, 40);
            this.timerLabel.TabIndex = 8;
            // 
            // questionTimer
            // 
            this.questionTimer.Interval = 1000;
            this.questionTimer.Tick += new System.EventHandler(this.questionTimer_Tick);
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.textBoxQuestion);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.buttonAnswerFour);
            this.Controls.Add(this.buttonAnswerThree);
            this.Controls.Add(this.buttonAnswerTwo);
            this.Controls.Add(this.buttonAnswerOne);
            this.Controls.Add(this.labelQuestionNum);
            this.Name = "QuizForm";
            this.Text = "QuizForm";
            this.Load += new System.EventHandler(this.QuizForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelQuestionNum;
        private Button buttonAnswerOne;
        private Button buttonAnswerTwo;
        private Button buttonAnswerThree;
        private Button buttonAnswerFour;
        private Button CloseButton;
        private TextBox textBoxQuestion;
        private Label timerLabel;
        private System.Windows.Forms.Timer questionTimer;
    }
}