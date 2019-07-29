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
        public static Int16 CheckPress; //เช็คกดหัวข้อ
        

        //ตัวแปรเก็บข้อมูลม.3/3//
        public static string Mon1_33;
        public static string Mon2_33;
        public static string Mon3_33;
        public static string Mon4_33;
        public static string Mon5_33;
        public static string Mon6_33;
        public static string Mon7_33;
        public static string Mon8_33;
        public static string Mon9_33;
        public static string Mon10_33;
        public static string Tue1_33;
        public static string Tue2_33;
        public static string Tue3_33;
        public static string Tue4_33;
        public static string Tue5_33;
        public static string Tue6_33;
        public static string Tue7_33;
        public static string Tue8_33;
        public static string Tue9_33;
        public static string Tue10_33;
        public static string Wed1_33;
        public static string Wed2_33;
        public static string Wed3_33;
        public static string Wed4_33;
        public static string Wed5_33;
        public static string Wed6_33;
        public static string Wed7_33;
        public static string Wed8_33;
        public static string Wed9_33;
        public static string Wed10_33;
        public static string Thu1_33;
        public static string Thu2_33;
        public static string Thu3_33;
        public static string Thu4_33;
        public static string Thu5_33;
        public static string Thu6_33;
        public static string Thu7_33;
        public static string Thu8_33;
        public static string Thu9_33;
        public static string Thu10_33;
        public static string Fri1_33;



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
