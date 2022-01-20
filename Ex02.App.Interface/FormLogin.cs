using System;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using Ex02.App.Logic;
using Facebook;
using FacebookWrapper;

namespace Ex02.App.InterFace
{
    public partial class FormLogin : Form
    {
        private LoggedUesr m_loggedInUser;

        private FacebookServiceFacade m_FacebookServiceFacade;

        public FormLogin()
        {
            m_FacebookServiceFacade = new FacebookServiceFacade();
            InitializeComponent();
        }

        private void buttonLogin_Click(object i_Sender, EventArgs i_)
        { 
           try
            {
                if(m_loggedInUser == null)
                {
                    m_loggedInUser = m_FacebookServiceFacade.ConnectWithAT();
                   // m_loggedInUser = m_FacebookServiceFacade.LoginToFacebook();
                }

                FormMain formMain = FactoryForm.CreateForm(eFormType.Main, m_loggedInUser) as FormMain;
                formMain.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonLogout_Click(object i_Sender, EventArgs i_)
        {
            try
            {
                if (m_loggedInUser != null)
                {
                    m_FacebookServiceFacade.LogoutFromFacebook();
                    buttonLogin.Text = "Login";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonExit_Click(object i_Sender, EventArgs i_)
        {
            Application.Exit();
        }
    }
}
