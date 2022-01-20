namespace Ex02.App.Logic
{
    public class QuizQuastion
    {
        public QuizQuastion(string i_Quastion, bool i_RequiredAnswer)
        {
            m_RequiredAnswer = i_RequiredAnswer;
            m_Quastion = i_Quastion;
        }

        private string m_Quastion;

        public string Quastion
        {
            get
            {
                return m_Quastion;
            }

            set
            {
                m_Quastion = value;
            }
        }

        private bool m_RequiredAnswer;

        public bool RequiredAnswer
        {
            get
            {
                return m_RequiredAnswer;
            }
        }
    }
}
