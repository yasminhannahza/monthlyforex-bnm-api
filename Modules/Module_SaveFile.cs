using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monthlyforex_bnm_api.Modules
{
    public static class InternModules
    {
        public static async Task SaveFile(string content, string fileName)
        {
            string thePath = await CheckSaveDirectory();

            FileStream fs = File.OpenWrite($"{thePath}\\{fileName}");

            byte[] theBytes = Encoding.Default.GetBytes(content);

            fs.Write(theBytes, 0, theBytes.Length);

            fs.Close();
        }

        private static async Task<string> CheckSaveDirectory()
        {
            DirectoryInfo di = new DirectoryInfo($"{Path.GetDirectoryName(Application.ExecutablePath)}\\Saved Files");

            if (!di.Exists)
            {
                di.Create();
            }

            return (di.FullName);
        }
    }
}
