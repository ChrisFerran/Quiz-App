using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizFront
{
    public partial class Form2 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;

        public Form2()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 5;

            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(count_down);
            timer1.Interval = 1000;
            timer1.Start();
        }

        private int duration; 

        private void count_down(object sender, EventArgs e)
        {

            if (duration == 0)
            {
                timer1.Stop();

                MessageBox.Show("You ran out of time");

                this.Close();
            }
            else if (duration > 0)
            {
                duration--;
                label1.Text = duration.ToString();
            }
        }

      
        private void askQuestion(int qnum)
        {
           this.AutoSize = true;

          

            switch (qnum)
            {


                case 1:
                    duration = 15;
                    lblQuestion.Text = "Who is the protagonist of the Uncharted Series";

                    button1.Text = "Kratos";
                    button2.Text = "Nathan Drake";
                    button3.Text = "Master Chief";
                    button4.Text = "Iron Man";

                    correctAnswer = 2;

                    break;

                case 2:
                    duration = 15;
                    lblQuestion.Text = "What year did Halo release?";

                    button1.Text = "2001";
                    button2.Text = "2000";
                    button3.Text = "1999";
                    button4.Text = "2002";

                    correctAnswer = 1;

                    break;

                case 3:
                    duration = 15;
                    lblQuestion.Text = "Which of these characters is not in Fortnite as of February 2022?";

                    button1.Text = "Kratos";
                    button2.Text = "Nathan Drake";
                    button3.Text = "Master Chief";
                    button4.Text = "Samus";

                    correctAnswer = 4;

                    break;

                case 4:
                    duration = 15;
                    lblQuestion.Text = "How many games are in the Super Mario Galaxy franchise?";

                    button1.Text = "1";
                    button2.Text = "2";
                    button3.Text = "3";
                    button4.Text = "4";

                    correctAnswer = 2;

                    break;

                case 5:
                    duration = 15;
                    lblQuestion.Text = "Which of these characters was not included as a dlc character in Super Smash Bros Ultimate?";

                    button1.Text = "Sora";
                    button2.Text = "Byleth";
                    button3.Text = "Terry";
                    button4.Text = "Waluigi";

                    correctAnswer = 4;

                    break;
            }

        }

        
        private void button1_Click(object sender, EventArgs e)
        {


            var senderObject = (Button)sender;
          


          int buttonTag = Convert.ToInt32(senderObject.Tag);



            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                   "Quiz Ended!" + Environment.NewLine +
                   "You have answered " + score + " questions correctly." + Environment.NewLine +
                   "Your total percentage is " + percentage + "%" + Environment.NewLine +
                   "Click OK to play again"
                   );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }

            questionNumber++;
            askQuestion(questionNumber);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;



            int buttonTag = Convert.ToInt32(senderObject.Tag);



            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                   "Quiz Ended!" + Environment.NewLine +
                   "You have answered " + score + " questions correctly." + Environment.NewLine +
                   "Your total percentage is " + percentage + "%" + Environment.NewLine +
                   "Click OK to play again"
                   );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }

            questionNumber++;
            askQuestion(questionNumber);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;



            int buttonTag = Convert.ToInt32(senderObject.Tag);



            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                   "Quiz Ended!" + Environment.NewLine +
                   "You have answered " + score + " questions correctly." + Environment.NewLine +
                   "Your total percentage is " + percentage + "%" + Environment.NewLine +
                   "Click OK to play again"
                   );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }

            questionNumber++;
            askQuestion(questionNumber);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;



            int buttonTag = Convert.ToInt32(senderObject.Tag);



            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                   "Quiz Ended!" + Environment.NewLine +
                   "You have answered " + score + " questions correctly." + Environment.NewLine +
                   "Your total percentage is " + percentage + "%" + Environment.NewLine +
                   "Click OK to play again"
                   );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }

            questionNumber++;
            askQuestion(questionNumber);
        }
    }
}
