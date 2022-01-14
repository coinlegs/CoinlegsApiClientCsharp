using System;
using CoinlegsApiClientCsharp.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CoinlegsApiClientCsharp.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase {
        [HttpPost("Listen")]
        public IActionResult Notify([FromBody] JObject content) {
            Notification notification = JsonConvert.DeserializeObject<Notification>(content.ToString());
            if (notification != null) {

                /*
                 * We show the notifications on the form for you to see the data. If you use this client application, probably you have an intention for autotrading.
                 * You need to write code here. For example if you want to start autotrading for blackfish, your code needs to start like this;
                 * 
                 * if(notification.Type == 503 && notification.SignalTypeId=1)
                 * {
                 *     Autotrading code will be here...
                 * 
                 *     Good luck :)
                 * }
                 * 
                 */

                Program.MainForm.Invoke(new Action(() => {
                    Program.NotifyList.Add(notification);
                }));
            }
            /*
             * You need to send this response for us to know you're receiving the notification correctly. If you don't send Ok() response, 
             * the system can stop sending notifications to your listener
             */
            return Ok();
        }
    }
}
