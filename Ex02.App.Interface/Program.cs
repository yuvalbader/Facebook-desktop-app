using System;
using System.Windows.Forms;
using FacebookWrapper;

namespace Ex02.App.InterFace
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Clipboard.SetText("design.patterns20cc");
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form formLogin = FactoryForm.CreateForm(eFormType.Login, null) as FormLogin;
            Application.Run(formLogin);
        }
    }
}
