using CoinlegsApiClientCsharp.Model;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CoinlegsApiClientCsharp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            string iconPath = $"{Path.GetDirectoryName(Application.ExecutablePath)}\\logo.ico";
            Icon = Icon.ExtractAssociatedIcon(iconPath);
        }

        private void FrmMain_Load(object sender, System.EventArgs e)
        {
            lbNotify.DataSource = Program.NotifyList;
            lbNotify.DisplayMember = "Display";
            lbNotify.ValueMember = "Display";
        }

        private void lbNotify_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                e.DrawBackground();
                Graphics g = e.Graphics;
                Notification notification = Program.NotifyList[e.Index];
                g.FillRectangle(notification.Signal == 0
                                    ? new SolidBrush(Color.LightSlateGray)
                                    : notification.Signal > 0
                                        ? new SolidBrush(Color.LightSeaGreen)
                                        : new SolidBrush(Color.IndianRed), e.Bounds);

                g.DrawString(notification.Display, e.Font, new SolidBrush(Color.White),
                             new PointF(e.Bounds.X, e.Bounds.Y));
            }
        }
    }
}
