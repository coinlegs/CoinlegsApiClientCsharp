
namespace CoinlegsApiClientCsharp
{
    partial class FrmMain
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
            this.lbNotify = new System.Windows.Forms.ListBox();
            this.lblNotificationCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNotify
            // 
            this.lbNotify.DisplayMember = "Display";
            this.lbNotify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNotify.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbNotify.FormattingEnabled = true;
            this.lbNotify.ItemHeight = 15;
            this.lbNotify.Location = new System.Drawing.Point(5, 5);
            this.lbNotify.Name = "lbNotify";
            this.lbNotify.Size = new System.Drawing.Size(815, 400);
            this.lbNotify.TabIndex = 0;
            this.lbNotify.ValueMember = "Display";
            this.lbNotify.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbNotify_DrawItem);
            // 
            // lblNotificationCount
            // 
            this.lblNotificationCount.AutoSize = true;
            this.lblNotificationCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNotificationCount.Location = new System.Drawing.Point(5, 405);
            this.lblNotificationCount.Name = "lblNotificationCount";
            this.lblNotificationCount.Size = new System.Drawing.Size(124, 15);
            this.lblNotificationCount.TabIndex = 1;
            this.lblNotificationCount.Text = "Incoming Notification";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 425);
            this.Controls.Add(this.lbNotify);
            this.Controls.Add(this.lblNotificationCount);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coinlegs Api Client";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox lbNotify;
        public System.Windows.Forms.Label lblNotificationCount;
    }
}