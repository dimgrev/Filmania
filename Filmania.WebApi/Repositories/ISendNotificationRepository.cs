using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filmania.WebApi.Repositories
{
    public interface ISendNotificationRepository
    {
        Task SendNotificationAsync(string reciepientEndpoint, string body);
    }
}
