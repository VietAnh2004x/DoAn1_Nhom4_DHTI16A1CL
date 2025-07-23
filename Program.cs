using DoAn.Forms.Main;
using DoAn.Forms.QLDangNhap;
//using OfficeOpenXml;

namespace DoAn
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new frmDangNhap());
        }
    }
}