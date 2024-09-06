using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotificationsController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<NotificationsController> _logger;

        public NotificationsController(ILogger<NotificationsController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> ReceiveNotification([FromBody] NotificationMessage notification)
        {
            if (notification == null)
            {
                return BadRequest("Invalid notification payload.");
            }


            System.Console.WriteLine($"Received notification of type: {notification.event_type}");
            System.Console.WriteLine($"Event ID: {notification.event_id}");
            System.Console.WriteLine($"Itinerary ID: {notification.itinerary_id}");
            System.Console.WriteLine($"Message: {notification.message}");

            return Ok();
        }
    }
}
