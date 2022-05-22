using System.Diagnostics;

namespace app
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            FormManager.LoginForm = new LoginForm();

            //Application.ApplicationExit += new EventHandler(EventManager.OnFormClosed);
            //loginForm.Closed += new EventHandler(EventManager.OnFormClosed);

            Application.Run(FormManager.LoginForm);
        }


    }
}