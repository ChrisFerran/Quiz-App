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
    public partial class Form3 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        public Form3()
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
                    lblQuestion.Text = "What streaming service offers the show Bojack Horseman?";

                    button1.Text = "Netflix";
                    button2.Text = "Hulu";
                    button3.Text = "HBO Max";
                    button4.Text = "Amazon Prime";

                    correctAnswer = 1;

                    break;

                case 2:
                    duration = 15;
                    lblQuestion.Text = "How many seasons are there of Game of Thrones?";

                    button1.Text = "6";
                    button2.Text = "7";
                    button3.Text = "8";
                    button4.Text = "9";

                    correctAnswer = 3;

                    break;

                case 3:
                    duration = 15;
                    lblQuestion.Text = "Which of these characters is not featured in The Mandelorian?";

                    button1.Text = "Luke Skywalker";
                    button2.Text = "Ahsoka Tano";
                    button3.Text = "Obi Wan Kenobi";
                    button4.Text = "Grogu";

                    correctAnswer = 3;

                    break;

                case 4:
                    duration = 15;
                    lblQuestion.Text = "Michael Scott is a chcaracter featured in what Sitcom?";

                    button1.Text = "Parks and Recreation";
                    button2.Text = "30 Rock";
                    button3.Text = "Community";
                    button4.Text = "The Office";

                    correctAnswer = 4;

                    break;

                case 5:
                    duration = 15;
                    lblQuestion.Text = "What is Rick's last name in Rick and Morty?";

                    button1.Text = "Sanchez";
                    button2.Text = "Brown";
                    button3.Text = "Davis";
                    button4.Text = "Miller";

                    correctAnswer = 1;

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
