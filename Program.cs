using Calculatrice;

namespace Form_Login
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormLogin login = new();
            login.ShowDialog();

            if (login.IsValidLogin == true)
            {
                FormMain Principal = new();
                Principal.ShowDialog();
            }




            //Application.Run(new FormLogin());

            //Application.Run(new FormMain());
        }
    }
}