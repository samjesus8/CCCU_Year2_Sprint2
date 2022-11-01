namespace QuizzApp
{
    partial class QuestionForm
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
            this.generalButton = new System.Windows.Forms.Button();
            this.filmsButton = new System.Windows.Forms.Button();
            this.musicButton = new System.Windows.Forms.Button();
            this.animalsButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // generalButton
            // 
            this.generalButton.Location = new System.Drawing.Point(10, 8);
            this.generalButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generalButton.Name = "generalButton";
            this.generalButton.Size = new System.Drawing.Size(202, 119);
            this.generalButton.TabIndex = 0;
            this.generalButton.Text = "General";
            this.generalButton.UseVisualStyleBackColor = true;
            this.generalButton.Click += new System.EventHandler(this.generalButton_Click);
            // 
            // filmsButton
            // 
            this.filmsButton.Location = new System.Drawing.Point(10, 133);
            this.filmsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filmsButton.Name = "filmsButton";
            this.filmsButton.Size = new System.Drawing.Size(202, 119);
            this.filmsButton.TabIndex = 1;
            this.filmsButton.Text = "Films";
            this.filmsButton.UseVisualStyleBackColor = true;
            this.filmsButton.Click += new System.EventHandler(this.filmsButton_Click);
            // 
            // musicButton
            // 
            this.musicButton.Location = new System.Drawing.Point(218, 8);
            this.musicButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.musicButton.Name = "musicButton";
            this.musicButton.Size = new System.Drawing.Size(202, 119);
            this.musicButton.TabIndex = 2;
            this.musicButton.Text = "Music";
            this.musicButton.UseVisualStyleBackColor = true;
            this.musicButton.Click += new System.EventHandler(this.musicButton_Click);
            // 
            // animalsButton
            // 
            this.animalsButton.Location = new System.Drawing.Point(218, 133);
            this.animalsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.animalsButton.Name = "animalsButton";
            this.animalsButton.Size = new System.Drawing.Size(200, 121);
            this.animalsButton.TabIndex = 3;
            this.animalsButton.Text = "Animals";
            this.animalsButton.UseVisualStyleBackColor = true;
            this.animalsButton.Click += new System.EventHandler(this.animalsButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 297);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 72);
            this.button1.TabIndex = 4;
            this.button1.Text = "Kids Mode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(162, 297);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 72);
            this.button3.TabIndex = 5;
            this.button3.Text = "Normal Mode";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(294, 297);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 72);
            this.button4.TabIndex = 6;
            this.button4.Text = "Hard Mode";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(12, 395);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(406, 29);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "HighScore - 0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 430);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.animalsButton);
            this.Controls.Add(this.musicButton);
            this.Controls.Add(this.filmsButton);
            this.Controls.Add(this.generalButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuestionForm";
            this.Text = "QuestionForm";
            this.Load += new System.EventHandler(this.QuestionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button generalButton;
        private Button filmsButton;
        private Button musicButton;
        private Button animalsButton;
        private Button button1;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
    }
}