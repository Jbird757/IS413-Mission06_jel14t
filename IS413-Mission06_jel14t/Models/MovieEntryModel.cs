using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IS413_Mission06_jel14t.Models
{

    public class CurrentYearRangeAttribute : RangeAttribute
    {
        public CurrentYearRangeAttribute(int minimum) : base(minimum, DateTime.Now.Year)
        {
            //ErrorMessage = "Year must be between {0} and the current year";
        }
    }
    public class MovieEntryModel
    {
        [Key]
        [Required]
        public int EntryID { get; set; }

        [Required(ErrorMessage = "The title field is required")]
        public string title { get; set; }

        [Required(ErrorMessage = "The year field is required")]
        [CurrentYearRange(1900, ErrorMessage ="Please enter a valid year. Valid years are from 1900 to the present")]
        public int year { get; set; }

        [Required(ErrorMessage = "The director field is required")]
        public string director { get; set; }

        [Required(ErrorMessage = "The rating field is required")]
        public string rating { get; set; }

        public bool edited { get; set; }

        public string lentTo { get; set; }

        [StringLength(25, ErrorMessage = "Notes must be 25 characters or less")]
        public string notes { get; set; }


        //Foreign Key
        [Required(ErrorMessage = "The category field is required")]
        [Range(1, 8, ErrorMessage ="You must select a Category")]
        public int categoryID { get; set; }
        public Category Category { get; set; }
    }
}
