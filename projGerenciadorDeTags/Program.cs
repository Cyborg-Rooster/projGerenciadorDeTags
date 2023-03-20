using projGerenciadorDeTags.Controller;

namespace projGerenciadorDeTags
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                DatabaseController.Initialize().Wait();
                ApplicationConfiguration.Initialize();
                Application.Run(new FrmMain());
            }
            catch(Exception e)
            {
                MessageBox.Show($"Não foi possível sincronizar com o banco de dados. Erro: {e.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}