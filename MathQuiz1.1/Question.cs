using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathQuiz1._1
{
    public enum Oper
    {
        plus, minus, multiplication, division
    }

    public class Question
    {
        int digit1;
        int digit2;
        Oper operat;

        public Question()
        {
            Random random = new Random();
            int operatorChoice = random.Next() % 4;

            switch (operatorChoice)
            {
                case 0:
                    operat = Oper.plus;
                    break;
                case 1:
                    operat = Oper.minus;
                    break;
                case 2:
                    operat = Oper.multiplication;
                    break;
                case 3:
                    operat = Oper.division;
                    break;
            }

            do
            {
                Digit2 = random.Next() % 20;
            } while (operat == Oper.division && Digit2 == 0);

            //Todo: om division börja med svaret, sen nämnaren
            if (operat == Oper.division)
            {
                int answer = random.Next() % 20;
                Digit1 = answer * Digit2;
            }
            else
            {
                Digit1 = random.Next() % 20;
            }
        }

        public Question(int digit1, int digit2)
        {
            Digit1 = digit1;
            Digit2 = digit2;
            operat = Oper.division;
        }

        internal int GetAnswerLength()
        {
            int answerLengthOneDeci;
            if (this.AnswerHasDecimal())
                answerLengthOneDeci = string.Format(GetIntAnswer() + "." + GetDecimal()).Length;
            else
                answerLengthOneDeci = GetIntAnswer().ToString().Length;

            return answerLengthOneDeci;
        }

        public int Digit1
        {
            get
            {
                return digit1;
            }
            set
            {
                digit1 = value;
            }
        }

        public int Digit2
        {
            get
            {
                return digit2;
            }
            set
            {
                digit2 = value;
            }
        }

        public string OperatorSymbol
        {
            get
            {
                switch (operat)
                {
                    case Oper.plus:
                        return "+";

                    case Oper.minus:
                        return "-";

                    case Oper.multiplication:
                        return "×";

                    case Oper.division:
                        return "÷";

                    default:
                        return "?";
                }
            }
        }

        public Oper Operator
        {
            get
            {
                return operat;
            }
        }

        public string GetAnswerString()
        {
            string answer = "";
            switch (operat)
            {
                case Oper.plus:
                    answer = (Digit1 + Digit2).ToString();
                    break;
                case Oper.minus:
                    answer = (Digit1 - Digit2).ToString();
                    break;
                case Oper.multiplication:
                    answer = (Digit1 * Digit2).ToString();
                    break;
                case Oper.division:
                    answer = (Digit1 / Digit2).ToString();
                    break;
            }
            return answer;
        }

        public int GetIntAnswer()
        {
            switch (operat)
            {
                case Oper.plus:
                    return (Digit1 + Digit2);
                case Oper.minus:
                    return (Digit1 - Digit2);
                case Oper.multiplication:
                    return (Digit1 * Digit2);
                case Oper.division:
                    return (Digit1 / Digit2);

                default:
                    return 0;
            }
        }

        public double GetOneDeciAnswer()
        {
            int intAnswer = this.GetIntAnswer();
            int deci = this.GetDecimal();
            double answer = (double)intAnswer;
            answer += (deci / 10);
            return answer;
        }

        public void Shake(MathQuizSettings settings)
        {
            Random random = new Random();
            int operatorChoice = random.Next() % 4;

            switch (operatorChoice)
            {
                case 0:
                    operat = Oper.plus;
                    break;
                case 1:
                    operat = Oper.minus;
                    break;
                case 2:
                    operat = Oper.multiplication;
                    break;
                case 3:
                    operat = Oper.division;
                    break;
            }

            if (settings.isset)
            {
                switch (operat)
                {
                    case Oper.division:

                        Digit2 = random.Next(settings.divisionMin2, settings.divisionMax2);

                        int answer = random.Next(settings.divisionAnswerMin, settings.divisionAnswerMax);

                        Digit1 = answer * Digit2;
                        //Todo alternativ att ha Digit1 och 2 genererade (från settings)
                        break;
                    case Oper.multiplication:
                        Digit1 = random.Next(settings.multiplicationMin1, settings.multiplicationMax1);
                        Digit2 = random.Next(settings.multiplicationMin2, settings.multiplicationMax2);
                        break;
                    case Oper.plus:
                        Digit1 = random.Next(settings.aditionMin1, settings.aditionMax1);
                        Digit2 = random.Next(settings.aditionMin2, settings.aditionMax2);
                        break;
                    case Oper.minus:
                        Digit1 = random.Next(settings.subtractionMin1, settings.subtractionMax1);
                        Digit2 = random.Next(settings.subtractionMin2, settings.subtractionMax2);
                        break;
                }
            }
            else
            {
                Digit1 = random.Next() % 20;

                do
                {
                    Digit2 = random.Next() % 20;
                } while (operat == Oper.division && Digit2 == 0);

            }

        }

        public bool AnswerHasDecimal()
        {
            if (operat != Oper.division)
            {
                return false;
            }
            else
            {
                if (Digit1 % Digit2 != 0)
                {
                    return true;
                }
                else
                    return false;
            }
        }

        public int GetDecimal()
        {
            if (AnswerHasDecimal())
            {
                int reminder = Digit1 % Digit2;
                int dec = (reminder * 10) / Digit2;
                return dec;
            }
            else
            {
                return 0;
            }
        }

        public bool UserAnswerIsCorrect(UserAnswer userAnswer)
        {

            if (!AnswerHasDecimal())
            {
                if (userAnswer.IsDeci)
                {
                    return false;
                }
                else
                {
                    if (this.GetIntAnswer() == userAnswer.IntValue)
                        return true;
                }
            }
            else
            {
                if (!userAnswer.IsDeci)
                {
                    return false;
                }
                else
                {
                    if (this.GetIntAnswer() == userAnswer.IntValue &&
                        this.GetDecimal() == userAnswer.Deci)
                    {
                        return true;
                    }
                }
                //Nedan fungerade för 12/11
                //if (GetOneDeciAnswer() - userAnswer.FloatValue == 0)
                //{
                //    return true;
                //}
                //else
                //{
                //    return false;
                //}
            }
            return false;

        }

        //Has a limit for length of Digit1 and Digit2
        public int NrOfAnswerRowsWhenSettingUpMultiplication()
        {
            int length1 = 1, length2 = 1, counter = 1;
            for (int i = 10; i < 10000; i *= 10)
            {
                if (Digit1 < i)
                {
                    length1 = counter;
                    break;
                }
                counter++;
            }
            counter = 1;
            for (int i = 10; i < 10000; i *= 10)
            {
                if (Digit2 < i)
                {
                    length2 = counter;
                    break;
                }
                counter++;
            }

            if (length1 < length2)
            {
                return length1;
            }
            else
            {
                return length2;
            }
        }

    }
}
