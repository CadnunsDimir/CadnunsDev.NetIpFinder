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
                var erro = e.Exception;
                var type = ex.GetType().Name;
                MessageBox.Show("[{0}] {1}".ToFormat(type, erro.Message));
            };
            Application.Run(new Form1());
        }
    }
}
