using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication9.Models;

namespace WebApplication9.ViewModels
{
    public class CoursesViewModel
    {
        
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}
