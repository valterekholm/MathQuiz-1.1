namespace MathQuiz1._1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewQuestion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxAnswer = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnAnswered = new System.Windows.Forms.Button();
            this.btnGetAnswer = new System.Windows.Forms.Button();
            this.lblLatOssBorja = new System.Windows.Forms.Label();
            this.lblAnswerHasDeci = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "MathQuiz1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 172);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 1;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnNewQuestion
            // 
            this.btnNewQuestion.Location = new System.Drawing.Point(348, 140);
            this.btnNewQuestion.Name = "btnNewQuestion";
            this.btnNewQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnNewQuestion.TabIndex = 3;
            this.btnNewQuestion.Text = "Ny Fråga";
            this.btnNewQuestion.UseVisualStyleBackColor = true;
            this.btnNewQuestion.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(221, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "=";
            // 
            // txtBoxAnswer
            // 
            this.txtBoxAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAnswer.Location = new System.Drawing.Point(251, 169);
            this.txtBoxAnswer.Name = "txtBoxAnswer";
            this.txtBoxAnswer.Size = new System.Drawing.Size(100, 30);
            this.txtBoxAnswer.TabIndex = 5;
            this.txtBoxAnswer.TextChanged += new System.EventHandler(this.txtBoxAnswer_TextChanged);
            this.txtBoxAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxAnswer_KeyPress);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfo.Location = new System.Drawing.Point(150, 258);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(3, 0, 45, 0);
            this.lblInfo.MaximumSize = new System.Drawing.Size(255, 0);
            this.lblInfo.MinimumSize = new System.Drawing.Size(0, 75);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 75);
            this.lblInfo.TabIndex = 6;
            // 
            // btnAnswered
            // 
            this.btnAnswered.Location = new System.Drawing.Point(358, 169);
            this.btnAnswered.Name = "btnAnswered";
            this.btnAnswered.Size = new System.Drawing.Size(65, 28);
            this.btnAnswered.TabIndex = 7;
            this.btnAnswered.Text = "Skicka";
            this.btnAnswered.UseVisualStyleBackColor = true;
            this.btnAnswered.Click += new System.EventHandler(this.btnAnswered_Click);
            // 
            // btnGetAnswer
            // 
            this.btnGetAnswer.Location = new System.Drawing.Point(477, 322);
            this.btnGetAnswer.Name = "btnGetAnswer";
            this.btnGetAnswer.Size = new System.Drawing.Size(27, 23);
            this.btnGetAnswer.TabIndex = 8;
            this.btnGetAnswer.Text = "?";
            this.btnGetAnswer.UseVisualStyleBackColor = true;
            this.btnGetAnswer.Click += new System.EventHandler(this.btnGetAnswer_Click);
            // 
            // lblLatOssBorja
            // 
            this.lblLatOssBorja.AutoSize = true;
            this.lblLatOssBorja.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatOssBorja.Location = new System.Drawing.Point(179, 46);
            this.lblLatOssBorja.Name = "lblLatOssBorja";
            this.lblLatOssBorja.Size = new System.Drawing.Size(150, 29);
            this.lblLatOssBorja.TabIndex = 9;
            this.lblLatOssBorja.Text = "Låt oss börja";
            // 
            // lblAnswerHasDeci
            // 
            this.lblAnswerHasDeci.AutoSize = true;
            this.lblAnswerHasDeci.Location = new System.Drawing.Point(85, 322);
            this.lblAnswerHasDeci.Name = "lblAnswerHasDeci";
            this.lblAnswerHasDeci.Size = new System.Drawing.Size(10, 13);
            this.lblAnswerHasDeci.TabIndex = 10;
            this.lblAnswerHasDeci.Text = "-";
            this.lblAnswerHasDeci.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "answerHasDeci";
            this.label4.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(347, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Ställ Upp";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAnswered;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 357);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAnswerHasDeci);
            this.Controls.Add(this.lblLatOssBorja);
            this.Controls.Add(this.btnGetAnswer);
            this.Controls.Add(this.btnAnswered);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtBoxAnswer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNewQuestion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(100, 90);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNewQuestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxAnswer;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnAnswered;
        private System.Windows.Forms.Button btnGetAnswer;
        private System.Windows.Forms.Label lblLatOssBorja;
        private System.Windows.Forms.Label lblAnswerHasDeci;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}

