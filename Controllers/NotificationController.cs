using System;
using CoinlegsApiClientCsharp.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CoinlegsApiClientCsharp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        [HttpPost("Listen")]
        public IActionResult Notify([FromBody] JObject content)
        {
            Notification notification = JsonConvert.DeserializeObject<Notification>(content.ToString());
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
