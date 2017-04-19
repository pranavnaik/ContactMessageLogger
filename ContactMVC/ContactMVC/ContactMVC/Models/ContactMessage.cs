using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContactMVC.Models
{
    public class ContactMessage
    {
        public int id { get; set; }

        [Required(ErrorMessage ="Enter the Name")]
        [DisplayName("Name:")]
        public string name { get; set; }

        [Required(ErrorMessage = "Enter the Email Address")]
        [RegularExpression(@"^[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]{1,50}$", ErrorMessage = "Please enter a valid email address.")]
        [DisplayName("Email:")]
        public string email { get; set; }

        [Required(ErrorMessage = "Enter the Subject")]
        [DisplayName("Subject:")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Enter the Message")]
        [DisplayName("Message:")]
        public string Message { get; set; }

        public string DateSent { get; set; }

    }
}