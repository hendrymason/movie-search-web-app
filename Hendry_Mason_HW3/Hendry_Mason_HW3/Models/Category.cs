using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hendry_Mason_HW3.Models
{
    public class Category
    {
        public Int32 CategoryID { get; set; }

        [Display(Name ="Category:")]
        public String CategoryName { get; set; }
        public List<Show> Shows { get; set; }

        public Category()
        {
            if (Shows == null)
            {
                Shows = new List<Show>();
            }
        }
    }
}
