using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GladVinduer.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GladVinduer.Models
{
    public class SimpleFormModel
    {
        [Required]
        public string Name { get; set; }

        public string Firm { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Message { get; set; }
    }
}