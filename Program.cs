using DoAn1_Nhom4_DHTI16A1CL.Forms.MainForm;

namespace DoAn
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