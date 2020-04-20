using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filmania.WebApi.Repositories
{
    public interface ISendNotificationRepository
    {
        Task SendNotificationAsync(List<string> reciepientsList, string body);
    }
}
