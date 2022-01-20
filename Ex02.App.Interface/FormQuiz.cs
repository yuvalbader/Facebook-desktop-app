using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using Ex02.App.Logic;

namespace Ex02.App.InterFace
{
    public partial class FormQuiz : Form
    {
        private LoggedUesr m_LoggedInUser;

        private User m_UserForQuiz;

        private Quiz m_QuizMatch;

         public FormQuiz(LoggedUesr i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
        }

        public void StartFormQuiz(User i_UserForQuiz)
        {
            m_UserForQuiz = i_UserForQuiz;
            quizUserPictureBox.LoadAsync(m_UserForQuiz.PictureSmallURL);
            LoggedInUserPictureBox.LoadAsync(m_LoggedInUser.PictureUrl);
            quizUserPictureBox.Image = m_UserForQuiz.ImageSmall;
            quizUserPictureBox.Text = m_UserForQuiz.Name;
            LoggedInUserPictureBox.Text = m_LoggedInUser.Name;
            m_QuizMatch = new Quiz(m_LoggedInUser, m_UserForQuiz);
            ShowDialog();
        }

        private void setQuastionBox()
        {
            quastionBox.Text = m_QuizMatch.Quastion;
        }

        private void fetchNextQuastionOrEndQuiz()
        {
            if (m_QuizMatch.IsQuizEnd())
            {
                optNo.Visible = false;
                optYes.Visible = false;
                submitbutton.Visible = false;
                checkButton.Visible = true;
                quastionBox.Text = "For results please press Check";
            }
            else
            {
                setQuastionBox();
            }
        }

        private void submitButton_Click(object i_Sender, EventArgs i_)
        {
            bool answer = false;
            if (optYes.Checked)
            {
                answer = true;
            }

            m_QuizMatch.CheckAnswer(answer);
            this.optNo.Checked = false;
            this.optYes.Checked = false;
            fetchNextQuastionOrEndQuiz();
        }
        
        private void checkButton_Click(object i_Sender, EventArgs i_)
        {
            this.groupBoxQuastions.Visible = false;
            quastionBox.Text = string.Empty;

            this.resultsLabel.Text =
                $"you and {m_QuizMatch.UserForQuizName} are {m_QuizMatch.GetResulet()} % matched";
            this.resultsLabel.Visible = true;
        }

        private void startQuizButton_Click(object i_Sender, EventArgs i_)
        { 
            string NotEnoughDataMsg = $"There is no enough data about {m_QuizMatch.UserForQuizName} to rely on in the quiz";
            try
            {
                m_QuizMatch.StartMatchQuiz();
            }
            catch(Exception ex)
            {
                MessageBox.Show(NotEnoughDataMsg);
            }

            if (m_QuizMatch.NumberQuastions == 0)
            {
                MessageBox.Show(NotEnoughDataMsg);
            }
            else
            {
                setQuastionBox();
                this.startQuizButton.Visible = false;
                this.groupBoxQuastions.Visible = true;
                this.checkButton.Visible = true;
                quastionBox.Visible = true;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}