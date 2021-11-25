
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
            this.components = new System.ComponentModel.Container();
            this.lbNotify = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblNotificationCount = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
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
            this.lbNotify.Size = new System.Drawing.Size(815, 391);
            this.lbNotify.TabIndex = 0;
            this.lbNotify.ValueMember = "Display";
            this.lbNotify.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbNotify_DrawItem);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAdress);
            this.panel1.Controls.Add(this.lblNotificationCount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(5, 396);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(815, 24);
            this.panel1.TabIndex = 3;
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblAdress.Location = new System.Drawing.Point(683, 5);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(127, 15);
            this.lblAdress.TabIndex = 3;
            this.lblAdress.Text = "";
            this.toolTip.SetToolTip(this.lblAdress, "Click Here To Copy");
            this.lblAdress.Click += new System.EventHandler(this.lblAdress_Click);
            // 
            // lblNotificationCount
            // 
            this.lblNotificationCount.AutoSize = true;
            this.lblNotificationCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNotificationCount.Location = new System.Drawing.Point(5, 5);
            this.lblNotificationCount.Name = "lblNotificationCount";
            this.lblNotificationCount.Size = new System.Drawing.Size(124, 15);
            this.lblNotificationCount.TabIndex = 2;
            this.lblNotificationCount.Text = "Incoming Notification";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 425);
            this.Controls.Add(this.lbNotify);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coinlegs API C# Client";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lbNotify;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.ToolTip toolTip;
        public System.Windows.Forms.Label lblNotificationCount;
    }
}