using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Filmania.WebApi.Models.ViewModel;
using Filmania.WebApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Filmania.WebApi.Controllers
{
    [Route("api/Notification")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private ISendNotificationRepository _sendEmailNotifRepo;
        
        public NotificationController(ISendNotificationRepository sendEmailNotifRepo)
        {
            _sendEmailNotifRepo = sendEmailNotifRepo;
        }

        [HttpPost]
        [Route("SendEmail")]
        public async Task<IActionResult> SendEmailNotificationAsync([FromBody] SendNotificationToEmailVM inputData)
        {
            await _sendEmailNotifRepo.SendNotificationAsync(inputData.EmailAddresses, inputData.Body);
            return Ok();
        }
    }
}