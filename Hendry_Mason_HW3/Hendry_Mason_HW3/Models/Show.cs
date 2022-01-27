using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hendry_Mason_HW3.Models
{
    public enum ShowType 
    {
        [Display(Name = "TV Show")] TV,
        [Display(Name = "Movie")] Movie
    }
    
    public enum Rating 
    { 
        [Display(Name = "G")] G, 
        [Display(Name = "PG")] PG,
        [Display(Name = "PG-13")] PG13,
        [Display(Name = "R")] R, 
        [Display(Name ="TV-G")] TVG,
        [Display(Name ="TV-PG")] TVPG,
        [Display(Name ="TV-Y" )] TVY,
        [Display(Name = "TV-Y7")] TVY7,
        [Display(Name ="TV-14")] TV14,
        [Display(Name ="TV-MA")] TVMA
    }
    public class Show
    {
        public Int32 ShowID { get; set; }

        [Display(Name ="Unique Identifier:")]
        public Int32 UniqueIdentifier { get; set; }

        [Display(Name ="Show Type:")]
        public ShowType ShowType { get; set; }

        [Display(Name = "Title:")]
        public String Title { get; set; }

        [Display(Name = "Director:")]
        public String Director { get; set; }

        [Display(Name = "Cast:")]
        public String Cast { get; set; }

        [Display(Name ="Date Added to Netflix:")]
        [DisplayFormat(DataFormatString = "{0:MMM d, yyyy}")]
        public DateTime DateAdded { get; set; }

        [Display (Name ="Release Year:")]
        public Int32 ReleaseYear { get; set; }

        [Display(Name = "Rating:")]
        public Rating Rating { get; set; }

        [Display(Name = "Duration:")]
        public String Duration { get; set; }

        [Display(Name = "Description:")]
        public String Description { get; set; }

        //Navigational property for Category
        // This sources information from the Category Model
        [Display(Name = "Category:")]
        public Category Category { get; set; }

    }
}
