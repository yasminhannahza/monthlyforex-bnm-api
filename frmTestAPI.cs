using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monthlyforex_bnm_api
{
    public partial class frmTestAPI : Form
    {
        public frmTestAPI()
        {
            InitializeComponent();
        }

        public async Task UpdateConsole(string message, Exception err = null)
        {
            string formattedMessage = $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}:\r\n" +
                $"{message}\r\n\r\n";

            if (err != null)
            {
                formattedMessage += $"Exception:\r\n" +
                    $"{err}\r\n\r\n";
            }

            this.Invoke(new Action(() =>
            {
                txtConsole.AppendText(formattedMessage);
            }));
        }

        private void btnHitAPI_Click(object sender, EventArgs e)
        {
            DateTime theDate = dtpForex.Value;
            string theCurrency = txtCurrency.Text.Trim();

            Task.Run(new Action(async () =>
            {
                await HitBNMAPI_Routine(theDate, theCurrency);
            }));
        }

        private void txtConsole_DoubleClick(object sender, EventArgs e)
        {
            txtConsole.Clear();
        }
    }
}
