using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * Author: Johaen Gnanakumar
 * Date: August 06, 2016
 * StudentID: 300880309
 * Description: a multi-form project that allows the user to select	a Movie	to view	from an	online	video streaming	service	called	“Movie	Bonanza”.
 * Version: 0.0.1
 */

namespace COMP123_S2016_ASSIGNMENT7
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
        }
    }
}
