using System;
using System.Text;



  




namespace CoinlegsApiClientCsharp.Model {
    public class Notification {

        /*
         * Fields for Alerts And Custom Signals
         */
        public int Type { get; set; }
        public string CustomSignalName { get; set; }
        public string Exchange { get; set; }
        public string MarketName { get; set; }
        public int Period { get; set; }
        public int Signal { get; set; }
        public DateTime SignalDate { get; set; }

        /*
         * Fields for Coinlegs Market Place Signals
         */
        public int? SignalTypeId { get; set; }
        public decimal? SignalPrice { get; set; }
        public decimal? StopLoss { get; set; }
        public decimal? Target1 { get; set; }
        public decimal? Target2 { get; set; }
        public decimal? Target3 { get; set; }
        public decimal? Target4 { get; set; }
        public decimal? Target5 { get; set; }
        public bool? Closed { get; set; }
        public DateTimeOffset? CloseDate { get; set; }
        public decimal? ClosePrice { get; set; }


        public string Display {
            get {
                StringBuilder sb = new StringBuilder();
                sb.Append(Signal == 0 ? "Uncertain" : Signal > 0 ? "Buy -> " : "Sell ->");
                sb.Append($" {Type} ");
                if (!string.IsNullOrEmpty(CustomSignalName))
                    sb.Append($" {CustomSignalName} ");
                sb.Append($" {Exchange} ");
                sb.Append($" {MarketName} ");
                sb.Append($" Period: {Period} ");
                if (Type == 503) {
                    sb.Append($" {SignalPrice} ");
                    sb.Append($" {Target1} ");
                    sb.Append($" {Target2} ");
                    sb.Append($" {Target3} ");
                    sb.Append($" {Target4} ");
                    sb.Append($" {Target5} ");
                    if (Closed == true)
                        sb.Append($" [Closed] ");
                }
                sb.Append($"{SignalDate.ToString("dd.MM.yyyy HH:mm:ss:fff")}");

                return sb.ToString();
            }
        }

    }
}
