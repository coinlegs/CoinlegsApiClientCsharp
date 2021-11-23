using System;
using CoinlegsApiClientCsharp.Helpers;
using CoinlegsApiClientCsharp.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CoinlegsApiClientCsharp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        [HttpPost]
        public IActionResult Notify([FromBody] string content)
        {
            Notification notification = JsonConvert.DeserializeObject<Notification>(content);
            if (notification != null)
            {
                Program.MainForm.Invoke(new Action(() =>
                                                   {
                                                       Program.NotifyList.Add(notification);
                                                   }));
            }

            return Ok();
        }
    }
}
