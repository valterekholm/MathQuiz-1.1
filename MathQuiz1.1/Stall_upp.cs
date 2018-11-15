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
    public partial class Stall_upp : Form
    {
        private Question question;

        List<TextBox> answerRow1;

        public string ReturnString { get; set; }


        public Stall_upp()
        {
            InitializeComponent();
        }

        public Stall_upp(Question question)
        {
            InitializeComponent();
            this.question = question;
            Console.WriteLine("Stall_upp konstr.");
            operatorText.Text = question.OperatorSymbol;

            answerRow1 = new List<TextBox>();

            //=
            Label equals = new Label();
            equals.Text = "=";
            equals.Width = 11;
            equals.Height = 25;
            if (question.Operator == Oper.division)
                answerPanel1.Controls.Add(equals);

            Console.WriteLine("{0}", question.GetIntAnswer() + "." + question.GetDecimal());
            int answerLengthOneDeci = question.GetAnswerLength();
            GetAnswerRow(question, answerLengthOneDeci);
            foreach (var tb in answerRow1)
            {
                //this.Controls.Add(tb);
                answerPanel1.Controls.Add(tb);
                Console.WriteLine("La till tb i answerPanel1 med värde {0}", tb.Text);
            }

            answerPanel1.BorderStyle = BorderStyle.None;

            if (question.Operator == Oper.division)
            {
                topNotesPanel.Padding = new Padding(37, 1, 1, 1);
                textBox1.TextAlign = HorizontalAlignment.Center;
                textBox2.TextAlign = HorizontalAlignment.Center;

                answerPanel1.Left = 159;
                answerPanel1.Top = 59;
            }
            else
            {
                answerPanel1.Controls.Add(equals);
                answerPanel1.FlowDirection = FlowDirection.RightToLeft;
                topNotesPanel.FlowDirection = answerPanel1.FlowDirection;

            }

            if (question.Operator == Oper.minus && (question.Digit1 < question.Digit2))
            {
                Tips.Text = string.Format("Subtrahenden är större än minuenden! Gör talet upp å ner ({0}-{1} osv...). Sen gör man differensen negativ; alltså sätter ett minustecken framför.", question.Digit2.ToString().Last(), question.Digit1.ToString().Last());
                Tips.BackColor = Color.Bisque;
                Tips.Padding = new Padding(3);
            }

            if (question.Operator == Oper.multiplication)
            {
                if (question.Digit1 > 9 && question.Digit2 > 9)
                {
                    //Todo: svar på flera rader
                    Console.WriteLine("Multiplikation med svar på flera rader ({0}x{1}).", question.Digit1, question.Digit2);
                    Console.WriteLine("Rader som behövs: {0}", question.NrOfAnswerRowsWhenSettingUpMultiplication());
                    //GetAnswerRow(question, answerLengthOneDeci);
                }
            }
        }

        private void GetAnswerRow(Question question, int answerLengthOneDeci)
        {
            for (int i = 1; i <= answerLengthOneDeci; i++)
            {
                TextBox tb = new TextBox();
                //tb.Right = this.Width - 30 - (i * 15);
                tb.Width = 11;
                tb.Height = 25;

                if (question.Operator != Oper.division)
                    tb.Left = textBox2.Left + (textBox2.Width - (i * (tb.Width - 1)));
                else
                    tb.Left = ((textBox2.Left + textBox2.Right) / 2) + i * (tb.Width - 1);

                tb.Top = textBox2.Bottom + 5;
                tb.Font = new Font(FontFamily.GenericMonospace, 13);
                tb.BorderStyle = BorderStyle.None;
                tb.BackColor = (i % 2 == 1) ? Color.LightGreen : Color.ForestGreen;
                tb.MaxLength = 1;
                tb.Name = "answerRow_1." + i;
                tb.Margin = new Padding(0);

                answerRow1.Add(tb);
            }
        }

        //Slut init

        private void Tb_TextChanged(object sender, EventArgs e)
        {
            //TODO: hoppa till nästa ruta
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Stall_upp_Activated(object sender, EventArgs e)
        {
            textBox1.Text = question.Digit1.ToString();
            textBox2.Text = question.Digit2.ToString();
            //answerPanel1 = flowLayoutPanel1;

            textBox2.ReadOnly = true;

            if (question.Operator == Oper.minus)
            {
                //Ska kunna låna
                textBox1.ReadOnly = false;
            }
            else
            {
                textBox1.ReadOnly = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void returningAnswer_Click(object sender, EventArgs e)
        {
            Console.WriteLine("returningAnswer_Click().");
            //DialogResult 
            Console.WriteLine("answerPanel Controls Count: {0}", answerPanel1.Controls.Count);
            if (question.Operator == Oper.division)
            {
                Console.WriteLine("Division");

                foreach (Control tb in answerPanel1.Controls)
                {
                    Console.WriteLine("En controll i answerpanel {0}", tb.ToString());
                    if (tb.GetType() == typeof(TextBox))
                    {
                        Console.WriteLine("Textbox");
                        ReturnString += tb.Text;
                    }
                    else
                    {
                        Console.WriteLine("Inte textbox");
                    }
                }
                //Console.WriteLine("Har samlat in answer med {0} tecken", ReturnString.Length);
            }
            else
            {
                Console.WriteLine("Inte Division");
                for (int i = answerPanel1.Controls.Count - 1; i >= 0; i--)
                {
                    Console.WriteLine("Steg {0} i loop", i);
                    if (answerPanel1.Controls[i].GetType() == typeof(TextBox))
                        ReturnString += answerPanel1.Controls[i].Text;
                }
            }
            Console.WriteLine("Ska skicka tillbaka {0}...", ReturnString);
            this.Close();
        }

        private void operatorText_Click(object sender, EventArgs e)
        {

        }

        private void Stall_upp_Load(object sender, EventArgs e)
        {

        }

        private void answerPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
