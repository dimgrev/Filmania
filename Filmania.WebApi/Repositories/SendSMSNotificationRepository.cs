﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filmania.WebApi.Repositories
{
    public class SendSMSNotificationRepository : ISendNotificationRepository
    {
        /// <summary>
        /// Sends SMS Notification to User.
        /// </summary>
        /// <param name="reciepientEndpoint"></param>
        /// <param name="body"></param>
        public Task SendNotificationAsync(List<string> reciepientsList, string body)
        {
            throw new NotImplementedException();
        }
    }
}
