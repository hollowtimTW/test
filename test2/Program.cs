using test2.Forms;

namespace test2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new fCategory());
        }
    }
}