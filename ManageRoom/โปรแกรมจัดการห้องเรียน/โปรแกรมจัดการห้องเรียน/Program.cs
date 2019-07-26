using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace โปรแกรมจัดการห้องเรียน
{
    static class Program
    {
        public static string language = "Thai"; //ตัวแปรกำหนดภาษา
        public static Int32 CheckClickDev; //ตัวแปรสำหรับเช็คการกดคณะผู้จัดทำ
        public static Int32 Room; //ตัวแปรสำหรับกำหนดห้องเรียนโดยใช้ Form เดียว
        


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_FirstPage());
        }
        
    }
}
