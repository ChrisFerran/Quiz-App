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
    public partial class Form5 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        public Form5()
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
                    lblQuestion.Text = "Which series does not feature an opening by Asian Kung Fu Generation?";

                    button1.Text = "Naruto";
                    button2.Text = "Full Metal Alchemist";
                    button3.Text = "Bleach";
                    button4.Text = "One Piece";

                    correctAnswer = 4;

                    break;

                case 2:
                    duration = 15;
                    lblQuestion.Text = "Which film was not directed by Hayao Miyazaki";

                    button1.Text = "Spirited Away";
                    button2.Text = "The Wind Rises";
                    button3.Text = "Grave of the Fireflies";
                    button4.Text = "My Neighbor Totoro";

                    correctAnswer = 3;

                    break;

                case 3:
                    duration = 15;
                    lblQuestion.Text = "What clan was Itachi ordered to destroy in Naruto Shippuden?";

                    button1.Text = "Uchiha";
                    button2.Text = "Uzumaki";
                    button3.Text = "Senju";
                    button4.Text = "Otsutsuki";

                    correctAnswer = 1;

                    break;

                case 4:
                    duration = 15;
                    lblQuestion.Text = "Who is the main antagonist of Bleach?";

                    button1.Text = "Ichigo Kurosaki";
                    button2.Text = "Yoruichi Shihouin";
                    button3.Text = "Orihime Inoue";
                    button4.Text = "Sōsuke Aizen";

                    correctAnswer = 4;

                    break;

                case 5:
                    duration = 15;
                    lblQuestion.Text = "What breed of dog is Ein in Cowboy Bebop?";

                    button1.Text = "Beagle";
                    button2.Text = "Corgi";
                    button3.Text = "Shiba Inu";
                    button4.Text = "Poodle";

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

