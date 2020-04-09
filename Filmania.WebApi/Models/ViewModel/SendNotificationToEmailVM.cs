using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Filmania.WebApi.Models.ViewModel
{
    public class SendNotificationToEmailVM
    {
        [JsonProperty("email")]
        [Required]
        public string EmailAddress { get; set; }

        [JsonProperty("body")]
        [Required]
        public string Body { get; set; }
    }
}
