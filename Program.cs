/* *
 * Phase 1 Programmers: Jeff Cribben, Mary Venegas
 * Date Started:  February 11, 2014
 * Date Completed: March 4, 2014
 * This Class Name: Program
 * -start the initial loging form- generated function by Visual Studio
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using System.IO; 
//when we have our xml
using System.Xml;


namespace Math_Monkeys
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
            Application.Run(new Form1Login());

           /* XmlDocument xd = new XmlDocument();
            xd.Load(@"\t.xml");
           // Console.WriteLine(xd.SelectSingleNode("Test/testitem/name").InnerText);
            //Console.ReadKey(); 
            * */
        }
    }
}
