using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using System.IO;

namespace Account_Manager
{
    static class Program
    {
    	public static readonly string PwPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                @"\LonamiWebs\PW_STOR";
    	public static readonly string PwFile = PwPath + "\\acm.pw";
    	
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            if (!File.Exists(PwFile))
                Application.Run(new FirstTimeF());
			
            else
                Application.Run(new MainWindowF());
        }
    }
}
