﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DIBN.Models
{
    public class MessageTemplateViewModel
    {
        public int Id { get; set; }
        [DisplayName("Name")]
        [Required(ErrorMessage = "Please Provide Name of this Email.")]
        public string Name { get; set; }
        [DisplayName("Subject")]
        [Required(ErrorMessage = "Please Provide Subject of this Email.")]
        public string Subject { get; set; }
        [DisplayName("Mail From")]
        [Required(ErrorMessage = "Please Provide Email From Which You want to Send this Mail.")]
        public string FromMail { get; set; }
        [DisplayName("Body")]
        [Required(ErrorMessage = "Please Provide Body of Your Email.")]
        public string Body { get; set; }
        [DisplayName("Is Active")]
        public bool IsActive { get; set; }
        [DisplayName("Is Delete")]
        public bool IsDelete { get; set; }
        public string CreatedOn { get; set; }
        public string ModifyOn { get; set; }
        public int CreatedBy { get; set; }
        public int ModifyBy { get; set; }
    }
}
