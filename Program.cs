using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KSM
{
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LoginForm());
            //Application.Run(new ScoreEntry());
            Application.Run(new MainForm());
            //Application.Run(new ChangeStudentInfo());
            //Application.Run(new LearningHistory());
            //Application.Run(new ChangeStudent())
            //Application.Run(new ChangeStaffInfo());
            //Application.Run(new BulkChangeStudentInfo());
            //Application.Run(new BulkChangeStaffInfo());

        }
    }
}
