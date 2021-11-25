using System;
using System.ComponentModel;
using System.Windows.Forms;
using CoinlegsApiClientCsharp.Model;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace CoinlegsApiClientCsharp
{
    static class Program
    {
        public static FrmMain MainForm { get; private set; }
        public static BindingList<Notification> NotifyList = new();

        [STAThread]
        static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().RunAsync();

            NotifyList.ListChanged += NotifyList_ListChanged;

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm = new FrmMain();
            Application.Run(MainForm);
        }

        private static void NotifyList_ListChanged(object sender, ListChangedEventArgs e)
        {
            MainForm.lblNotificationCount.Text = $"Incoming Notification : {NotifyList.Count}";
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args).UseKestrel().UseUrls("http://0.0.0.0:5000").UseStartup<Startup>();
    }
}
