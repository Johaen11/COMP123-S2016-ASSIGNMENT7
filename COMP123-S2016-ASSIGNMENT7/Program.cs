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
 * Version: 0.0.2
 */

namespace COMP123_S2016_ASSIGNMENT7
{
    static class Program
    {
        public static SplashScreenForm splashScreen;
        public static SelectionForm selectionForm;
        public static OrderForm orderForm;
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

           

            splashScreen = new SplashScreenForm();
            selectionForm = new SelectionForm();
            orderForm = new OrderForm();
            
            Application.Run(splashScreen);

            /*
             Cedar Rapids
Company Men
Death Race 2
FootLoose
Gnomeo and Juliet
I am Number Four
Just Go With It
No String Attached
Real Steel
Sanctum
Season of the Witch
The Dilemma
The Eagle
The Green Hornet
The Mechanic
The Other Woman
The Rite
The Roommate
The Way Back
Waiting for Forever
             */
        }
    }
}
