using System.Windows.Forms;
using Ex02.App.Logic;

namespace Ex02.App.InterFace
{
    public static class FactoryForm 
    {
        public static object CreateForm(eFormType i_FormType, LoggedUesr i_LoggedInUser)
        {
            object toReturn = null;

            if(i_FormType == eFormType.Login)
            {
                toReturn =  new FormLogin();
            }
            else if(i_FormType == eFormType.Main)
            {
                toReturn = new FormMain(i_LoggedInUser);
            }
            else if(i_FormType == eFormType.Quiz)
            {
                toReturn = new FormQuiz(i_LoggedInUser);
            }

            return toReturn;
        }
    }
}