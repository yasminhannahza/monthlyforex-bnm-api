namespace monthlyforex_bnm_api
{
    partial class frmTestAPI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpForex = new System.Windows.Forms.DateTimePicker();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnHitAPI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpForex
            // 
            this.dtpForex.Location = new System.Drawing.Point(182, 27);
            this.dtpForex.Name = "dtpForex";
            this.dtpForex.Size = new System.Drawing.Size(200, 20);
            this.dtpForex.TabIndex = 0;
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(11, 27);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(109, 20);
            this.txtCurrency.TabIndex = 1;
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(11, 105);
            this.txtConsole.Margin = new System.Windows.Forms.Padding(2);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsole.Size = new System.Drawing.Size(583, 334);
            this.txtConsole.TabIndex = 4;
            this.txtConsole.DoubleClick += new System.EventHandler(this.txtConsole_DoubleClick);
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Location = new System.Drawing.Point(12, 9);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(71, 13);
            this.lblCurrency.TabIndex = 5;
            this.lblCurrency.Text = "The Currency";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(179, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(52, 13);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "The Date";
            // 
            // btnHitAPI
            // 
            this.btnHitAPI.Location = new System.Drawing.Point(507, 27);
            this.btnHitAPI.Name = "btnHitAPI";
            this.btnHitAPI.Size = new System.Drawing.Size(85, 59);
            this.btnHitAPI.TabIndex = 7;
            this.btnHitAPI.Text = "Get Rates from BNM";
            this.btnHitAPI.UseVisualStyleBackColor = true;
            this.btnHitAPI.Click += new System.EventHandler(this.btnHitAPI_Click);
            // 
            // frmTestAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 450);
            this.Controls.Add(this.btnHitAPI);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.txtCurrency);
            this.Controls.Add(this.dtpForex);
            this.Name = "frmTestAPI";
            this.Text = "Bank Negara Forex API Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpForex;
        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnHitAPI;
    }
}

