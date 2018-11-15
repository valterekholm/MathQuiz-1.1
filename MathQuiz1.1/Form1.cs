using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz1._1
{
    public struct MathQuizSettings
    {
        public bool isset;

        public int divisionMax1;
        public int divisionMin1;
        public int divisionMax2;
        public int divisionMin2;
        public int multiplicationMax1;
        public int multiplicationMin1;
        public int multiplicationMax2;
        public int multiplicationMin2;
        public int aditionMax1;
        public int aditionMin1;
        public int aditionMax2;
        public int aditionMin2;
        public int subtractionMax1;
        public int subtractionMin1;
        public int subtractionMax2;
        public int subtractionMin2;
        public int divisionAnswerMin;
        public int divisionAnswerMax;
    }
    public partial class Form1 : Form
    {
        Question question = new Question(12, 11);
        UserAnswer userAnswer = new UserAnswer();
        char lastKey;
        bool hasComma;
        int decimalZeroCount, decimalCount;
        MathQuizSettings settings;

        //counters during progress
        int questionCounter = 0, rightCounter = 0, wrongCounter = 0;

        public Form1()
        {
            InitializeComponent();
            //To do: Hämta 
            settings.divisionMax1 = 15;
            settings.divisionMin1 = 5;
            settings.divisionMax2 = 10;
            settings.divisionMin2 = 1;
            settings.multiplicationMax1 = 11;
            settings.multiplicationMin1 = 10;//1
            settings.multiplicationMax2 = 14;
            settings.multiplicationMin2 = 10;//5
            settings.aditionMax1 = 60;
            settings.aditionMin1 = -1;
            settings.aditionMax2 = 75;
            settings.aditionMin2 = 10;
            settings.subtractionMax1 = 200;
            settings.subtractionMin1 = 50;
            settings.subtractionMax2 = 49;
            settings.subtractionMin2 = 1;
            settings.divisionAnswerMin = 3;
            settings.divisionAnswerMax = 14;
            settings.isset = true;


            label2.Text = question.Digit1 + " " + question.OperatorSymbol + " " + question.Digit2;

            if (question.Operator == Oper.division)
            {
                lblInfo.Text = "Om det blir decimaler, skriv bara en (utan avrundning)...";
            }
            else
            {
                lblInfo.Text = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            question.Shake(settings);
            label2.Text = question.Digit1 + " " + question.OperatorSymbol + " " + question.Digit2;

            if (question.Operator == Oper.division && question.AnswerHasDecimal())
            {
                lblInfo.Text = "Om det blir decimaler, skriv bara en (utan avrundning)...";
            }
            else
            {
                lblInfo.Text = "";
            }
            txtBoxAnswer.Text = "";


            if (lblLatOssBorja.Visible == true)
            {
                lblLatOssBorja.Visible = false;
            }

            ResetStyle();
            txtBoxAnswer.Focus();
        }

        private void btnAnswered_Click(object sender, EventArgs e)
        {


            if (txtBoxAnswer.Text.Contains('.'))
            {
                txtBoxAnswer.Text = txtBoxAnswer.Text.Replace('.', ',');
            }

            if (hasComma && decimalCount == decimalZeroCount && decimalCount > 1)
            {
                //Ta bort onödiga nollor
                txtBoxAnswer.Text = txtBoxAnswer.Text.Remove(txtBoxAnswer.Text.IndexOf(',') + 1, decimalCount - 1);
            }
            if (userAnswer.SetAnswer(txtBoxAnswer.Text))
            {


                lblInfo.Text = "Lyckades ta answer - " + userAnswer.ToString();
                if (question.UserAnswerIsCorrect(userAnswer))
                {
                    lblInfo.Text = "Rätt";
                    lblInfo.BackColor = Color.Green;
                    userAnswer.Clear();
                    btnNewQuestion.Focus();
                    rightCounter++;
                }
                else
                {
                    lblInfo.Text = userAnswer.ToString() + " är Fel ";//+ userAnswer.IsDeci;
                    lblInfo.BackColor = Color.RosyBrown;
                    userAnswer.Clear();
                    wrongCounter++;
                }

                lblAnswerHasDeci.Text = question.AnswerHasDecimal().ToString();
                questionCounter++;
            }
            else
            {
                lblInfo.Text = "Lyckades ej ta answer";
                lblInfo.BackColor = Color.Gray;
            }
        }

        private void btnGetAnswer_Click(object sender, EventArgs e)
        {
            if (!question.AnswerHasDecimal())
                lblInfo.Text = question.GetAnswerString();
            else
            {
                lblInfo.Text = question.GetIntAnswer().ToString() + "," + question.GetDecimal().ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtBoxAnswer_TextChanged(object sender, EventArgs e)
        {
            //lblInfo.Text = e.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetStyle();
            using (var stallUpp = new Stall_upp(question))
            {
                stallUpp.ShowDialog(this);
                txtBoxAnswer.Text = stallUpp.ReturnString;
                btnAnswered.PerformClick();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //results
            
            String message = "Antal frågor: " + questionCounter + "\nantal rätt svar: " + rightCounter + "\nantal fel svar: " + wrongCounter + "\nVill du stänga?\n\n(Svar sparas ej)";
            Console.Out.WriteLine(message);
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, "Stänga spelet?", buttons);

            if(result == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            ResetStyle();
        }

        private void ResetStyle()
        {
            lblInfo.BackColor = this.BackColor;
        }

        private void txtBoxAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            lastKey = e.KeyChar;
            switch (lastKey)
            {
                case ',':
                case '.':
                    hasComma = true;
                    decimalZeroCount = decimalCount = 0;
                    break;
                case '0':
                    decimalZeroCount++;
                    break;


            }
            if (lastKey >= '0' && lastKey <= '9') decimalCount++;
        }
    }
}
