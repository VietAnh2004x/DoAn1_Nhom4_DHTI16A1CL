using DoAn1.Forms.Main;
using DoAn1.Forms.QLDangNhap;
//using OfficeOpenXml;

namespace DoAn1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            

            ApplicationConfiguration.Initialize();
          //  Application.Run(new MainForm());
            Application.Run(new usDangNhap());
        }
    }
}