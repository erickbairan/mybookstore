﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyBookstore.Models
{
    public class PublishersModels
    {
        [Key]
        public int ID{ get; set; }
        [Display(Name = "Publisher Name")]
        [MaxLength(40, ErrorMessage = "Up to 40 characters only!")]
        [Required(ErrorMessage = "Required!")]
        public string pubName { get; set; }

    }
}