using Newtonsoft.Json;

namespace CoinlegsApiClientCsharp.Helpers
{
    public static class Helper
    {
        public static bool IsValidJson<T>(this string strInput)
        {
            strInput = strInput.Trim();
            if ((strInput.StartsWith("{") && strInput.EndsWith("}")) || //For object
                (strInput.StartsWith("[") && strInput.EndsWith("]"))) //For array
            {
                try
                {
                    JsonConvert.DeserializeObject<T>(strInput);
                    return true;
                }
                catch // not valid
                {
                    return false;
                }
            }

            return false;
        }

    }
}
