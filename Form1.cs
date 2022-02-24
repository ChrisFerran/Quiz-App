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
    


    public partial class Form1 : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;


        public Form1()
        {
            
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 5;
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            

            var senderObject = (Button)sender;

           

            int buttonTag = Convert.ToInt32(senderObject.Tag);



            if(buttonTag == 1)
            {
                score++;

              
                this.Hide();
                var form2 = new Form2();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
               
            }
            else if(buttonTag == 2)
            {
               

                this.Hide();
                var form3 = new Form3();
                form3.Closed += (s, args) => this.Close();
                form3.Show();
            }
            else if(buttonTag == 3)
            {
               
                this.Hide();
                var form4 = new Form4();
                form4.Closed += (s, args) => this.Close();
                form4.Show();
            }
            else if (buttonTag == 4)
            {
               
                this.Hide();
                var form5 = new Form5();
                form5.Closed += (s, args) => this.Close();
                form5.Show();

            }

           

            if(questionNumber == totalQuestions)
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

       

       private void askQuestion(int qnum)
           {
            

            switch (qnum)
            {
               case 1:

                   lblQuestion.Text = "Select a Quiz";

                   button1.Text = "Video Games";
                    button2.Text = "Television";
                    button3.Text = "Movies";
                    button4.Text = "Anime";

                  

                   correctAnswer = 1;

                    break;

             
            }

        }
    }
}
