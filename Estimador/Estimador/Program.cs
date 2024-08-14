namespace Estimador
{
    internal static class Program
    {
        /// <summary>
        ///  Hecho por Vigo Saldaña Alberth Jesus
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new StartMenu(1));
        }
    }
}