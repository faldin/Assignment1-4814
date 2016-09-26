//Eduardo M. Martin
//Samuel Van Dalen
//COP 4814 U03 - Component Based Software Dev - Fall 2016
//Assignment1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//Samuel van Dalen and Eduardo Martinez
namespace Hotel_Reservations
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
            Application.Run(new CreateFilesForm());
        }
    }
}