using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadnunsDev.NetIPFinder
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
            Application.ThreadException += (ex,e) =>{
                var erro = ex as Exception;
                MessageBox.Show(erro.Message);
            };
            Application.Run(new Form1());
        }
    }
}
