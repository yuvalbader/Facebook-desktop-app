namespace Ex02.App.InterFace
{
    public partial class FormQuiz
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
            this.optYes = new System.Windows.Forms.RadioButton();
            this.optNo = new System.Windows.Forms.RadioButton();
            this.quastionBox = new System.Windows.Forms.Label();
            this.submitbutton = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.groupBoxQuastions = new System.Windows.Forms.GroupBox();
            this.chooseAnswerLabel = new System.Windows.Forms.Label();
            this.quizUserPictureBox = new System.Windows.Forms.PictureBox();
            this.LoggedInUserPictureBox = new System.Windows.Forms.PictureBox();
            this.startQuizButton = new System.Windows.Forms.Button();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.groupBoxQuastions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quizUserPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoggedInUserPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // optYes
            // 
            this.optYes.AutoSize = true;
            this.optYes.Location = new System.Drawing.Point(74, 117);
            this.optYes.Name = "optYes";
            this.optYes.Size = new System.Drawing.Size(62, 24);
            this.optYes.TabIndex = 63;
            this.optYes.TabStop = true;
            this.optYes.Text = "Yes";
            this.optYes.UseVisualStyleBackColor = true;
            // 
            // optNo
            // 
            this.optNo.AutoSize = true;
            this.optNo.Location = new System.Drawing.Point(363, 117);
            this.optNo.Name = "optNo";
            this.optNo.Size = new System.Drawing.Size(54, 24);
            this.optNo.TabIndex = 64;
            this.optNo.TabStop = true;
            this.optNo.Text = "No";
            this.optNo.UseVisualStyleBackColor = true;
            // 
            // quastionBox
            // 
            this.quastionBox.AutoSize = true;
            this.quastionBox.Location = new System.Drawing.Point(22, 22);
            this.quastionBox.Name = "quastionBox";
            this.quastionBox.Size = new System.Drawing.Size(77, 20);
            this.quastionBox.TabIndex = 66;
            this.quastionBox.Text = "Quastion:";
            // 
            // submitbutton
            // 
            this.submitbutton.Location = new System.Drawing.Point(122, 200);
            this.submitbutton.Name = "submitbutton";
            this.submitbutton.Size = new System.Drawing.Size(174, 42);
            this.submitbutton.TabIndex = 67;
            this.submitbutton.Text = "Submit";
            this.submitbutton.UseVisualStyleBackColor = true;
            this.submitbutton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(122, 200);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(174, 42);
            this.checkButton.TabIndex = 68;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // groupBoxQuastions
            // 
            this.groupBoxQuastions.Controls.Add(this.chooseAnswerLabel);
            this.groupBoxQuastions.Controls.Add(this.optYes);
            this.groupBoxQuastions.Controls.Add(this.optNo);
            this.groupBoxQuastions.Controls.Add(this.submitbutton);
            this.groupBoxQuastions.Controls.Add(this.quastionBox);
            this.groupBoxQuastions.Controls.Add(this.checkButton);
            this.groupBoxQuastions.Location = new System.Drawing.Point(128, 162);
            this.groupBoxQuastions.Name = "groupBoxQuastions";
            this.groupBoxQuastions.Size = new System.Drawing.Size(528, 275);
            this.groupBoxQuastions.TabIndex = 70;
            this.groupBoxQuastions.TabStop = false;
            this.groupBoxQuastions.Visible = false;
            // 
            // chooseAnswerLabel
            // 
            this.chooseAnswerLabel.AutoSize = true;
            this.chooseAnswerLabel.Location = new System.Drawing.Point(6, 89);
            this.chooseAnswerLabel.Name = "chooseAnswerLabel";
            this.chooseAnswerLabel.Size = new System.Drawing.Size(198, 20);
            this.chooseAnswerLabel.TabIndex = 69;
            this.chooseAnswerLabel.Text = "Please choose an answer: ";
            // 
            // QuizUserPictureBox
            // 
            this.quizUserPictureBox.Location = new System.Drawing.Point(418, 12);
            this.quizUserPictureBox.Name = "QuizUserPictureBox";
            this.quizUserPictureBox.Size = new System.Drawing.Size(99, 88);
            this.quizUserPictureBox.TabIndex = 71;
            this.quizUserPictureBox.TabStop = false;
            // 
            // LoggedInUserPictureBox
            // 
            this.LoggedInUserPictureBox.Location = new System.Drawing.Point(236, 12);
            this.LoggedInUserPictureBox.Name = "LoggedInUserPictureBox";
            this.LoggedInUserPictureBox.Size = new System.Drawing.Size(99, 88);
            this.LoggedInUserPictureBox.TabIndex = 72;
            this.LoggedInUserPictureBox.TabStop = false;
            // 
            // startQuizButton
            // 
            this.startQuizButton.Location = new System.Drawing.Point(255, 120);
            this.startQuizButton.Name = "startQuizButton";
            this.startQuizButton.Size = new System.Drawing.Size(226, 35);
            this.startQuizButton.TabIndex = 73;
            this.startQuizButton.Text = "Start quiz";
            this.startQuizButton.UseVisualStyleBackColor = true;
            this.startQuizButton.Click += new System.EventHandler(this.startQuizButton_Click);
            // 
            // ResultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Location = new System.Drawing.Point(151, 127);
            this.resultsLabel.Name = "ResultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(77, 20);
            this.resultsLabel.TabIndex = 70;
            this.resultsLabel.Text = "Quastion:";
            this.resultsLabel.Visible = false;
            // 
            // Cancelbutton
            // 
            this.cancelbutton.Location = new System.Drawing.Point(663, 412);
            this.cancelbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelbutton.Name = "Cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(124, 32);
            this.cancelbutton.TabIndex = 74;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // FormQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.groupBoxQuastions);
            this.Controls.Add(this.startQuizButton);
            this.Controls.Add(this.LoggedInUserPictureBox);
            this.Controls.Add(this.quizUserPictureBox);
            this.Name = "FormQuiz";
            this.groupBoxQuastions.ResumeLayout(false);
            this.groupBoxQuastions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quizUserPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoggedInUserPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton optYes;
        private System.Windows.Forms.RadioButton optNo;
        private System.Windows.Forms.Label quastionBox;
        private System.Windows.Forms.Button submitbutton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.GroupBox groupBoxQuastions;
        private System.Windows.Forms.PictureBox quizUserPictureBox;
        private System.Windows.Forms.PictureBox LoggedInUserPictureBox;
        private System.Windows.Forms.Label chooseAnswerLabel;
        private System.Windows.Forms.Button startQuizButton;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.Button cancelbutton;
    }
}
