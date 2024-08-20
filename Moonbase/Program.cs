using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moonbase
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {

            // This method enables visual styles for the application. 
            Application.EnableVisualStyles();
            // This method sets the default value for new controls in a .NET 1.x application.
            Application.SetCompatibleTextRenderingDefault(false);
            // This method runs the Aeris form
            Application.Run(new Aeris());

            }


        }
    }

