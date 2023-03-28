using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebApplication9.Models;

namespace WebApplication9.ViewModels
{
    public class CourseViewModel
    
    {
        [Required]
        public string Place { get; set; }
        [Required]
        [FutureData]
        public string Date { get; set; }
        [Required]
        [ValidTime]
        public string Time { get; set; }
        [Required]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
           return DateTime.Parse(string.Format("{0} {1}" , Date,Time));
        }
    }
}