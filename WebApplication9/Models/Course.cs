﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication9.Models
{
    public class Course
    {
        public int Id { get; set; }
        public ApplicationUser Lecturer{ get; set; }
        [Required]
        public string LucturerId { get; set; }
        [Required]
        [StringLength(250)]
        public string Place { get; set; }
        public DateTime DateTime { get; set; }  
        public Category Category { get; set; }
        [Required]
        public byte CategoryId { get; set; }
        public string LecturerId { get; internal set; }
    }
}