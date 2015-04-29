using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            string First_Name = "Shawn";
            string Last_Name = "Lee";
            string Birthdate = "1991/12/19";
            int Age = 24;
            string City = "Kaohsiung";

            string pro_name = "Prof. Richard Lin";

            string Degree = "Master of Department of Computer Science and Engineering";

            Console.WriteLine("\n\nStudent information");
            Console.WriteLine("\tName:" + First_Name + " " + Last_Name);
            Console.WriteLine("\tBirthdate:" + Birthdate);
            Console.WriteLine("\tAge:" + Age);
            Console.WriteLine("\tCity:" + City);
            Console.WriteLine("\tDegree:" + Degree);
            Console.WriteLine("Professor information");
            Console.WriteLine("\tName:" + pro_name + "\n\n");
        }
    }
}
