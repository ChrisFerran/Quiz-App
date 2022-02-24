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
    public partial class Form4 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        public Form4()
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
                    lblQuestion.Text = "Which Star Wars movie does not include C3P0";

                    button1.Text = "The Phantom Menace";
                    button2.Text = "Rogue One";
                    button3.Text = "A New Hope";
                    button4.Text = "Solo";

                    correctAnswer = 4;

                    break;

                case 2:
                    duration = 15;
                    lblQuestion.Text = "What year did the original Godzilla come out?";

                    button1.Text = "1954";
                    button2.Text = "1949";
                    button3.Text = "1962";
                    button4.Text = "1961";

                    correctAnswer = 1;

                    break;

                case 3:
                    duration = 15;
                    lblQuestion.Text = "Who directed Goodfellas?";

                    button1.Text = "Quentin Tarantino";
                    button2.Text = "Martin Scorsese";
                    button3.Text = "Steven Spielberg";
                    button4.Text = "Francis Ford Coppola";

                    correctAnswer = 2;

                    break;

                case 4:
                    duration = 15;
                    lblQuestion.Text = "What is the first name of the protagonist of the Die Hard franchise?";

                    button1.Text = "John";
                    button2.Text = "Hans";
                    button3.Text = "Al";
                    button4.Text = "Harry";

                    correctAnswer = 1;

                    break;

                case 5:
                    duration = 15;
                    lblQuestion.Text = "Which of the following movies is not part of the Marvel Cinematic Universe?";

                    button1.Text = "Iron Man";
                    button2.Text = "Ghost Rider";
                    button3.Text = "The Eternals";
                    button4.Text = "Shang-Chi and the Legend of the Ten Rings";

                    correctAnswer = 2;

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

