namespace Tchiho_Story_01
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}