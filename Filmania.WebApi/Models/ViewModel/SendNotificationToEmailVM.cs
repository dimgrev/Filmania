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
        [Required]
        [JsonProperty("emails")]
        public List<string> EmailAddresses { get; set; }

        [Required]
        [JsonProperty("body")]
        public string Body { get; set; }
    }
}
