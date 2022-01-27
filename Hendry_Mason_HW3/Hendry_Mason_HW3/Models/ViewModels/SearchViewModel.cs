using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Hendry_Mason_HW3.Models
{
    //This SearchViewModel contains information you would like
    //to present in a View but without storing it in a Database
    public enum Typeof
    {
        Before, After
    }

    public class SearchViewModel
    {
        [Display(Name = "Search By Title:")]
        public string Title { get; set; }

        [Display(Name = "Search By Cast:")]
        public string Cast { get; set; }

        [Display(Name = "Search By Date Added to Netflix:")]
        public DateTime? DateAdded { get; set; }

        [Display(Name = "Search By Year Released:")]
        public int? YearReleased { get; set; }

        [Display(Name = "Type of Search:")]
        public Typeof SearchType { get; set; }

        [Display(Name = "Search By Description:")]
        public string Description { get; set; }

        [Display(Name = "Search By Category:")]
        public Int32 Category { get; set; }

        [Display(Name = "Search By Rating:")]
        public Rating? searchRating { get; set; }
    }
}
