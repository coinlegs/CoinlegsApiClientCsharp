using System;

namespace CoinlegsApiClientCsharp.Model
{
    public class Notification
    {
        public int Type { get; set; }
        public string CustomSignalName { get; set; }
        public string Exchange { get; set; }
        public string MarketName { get; set; }
        public int Period { get; set; }
        public int Signal { get; set; }
        public DateTime SignalDate { get; set; }

        public string Display
        {
            get
            {
                string signal = Signal == 0 ? "Uncertain" : Signal > 0 ? "Buy -> " : "Sell ->";
                
                return $" {signal}  Type : {Type} {(!string.IsNullOrEmpty(CustomSignalName) ? $"- Custom Signal Name : {CustomSignalName}" : "")} - Exchange : {Exchange} - MarketName : {MarketName} - Period : {Period}  - Signal Date : {SignalDate:dd.MM.yyyy HH:mm:ss:fff}";
            }
        }
            
    }
}
