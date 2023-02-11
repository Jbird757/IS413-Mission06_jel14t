using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IS413_Mission06_jel14t.Models
{
    public class MovieEntryModel
    {
        static int GetCurrentYear()
        {
            string CurrentYear = DateTime.Now.Year.ToString();
            int numYear = int.Parse(CurrentYear);

            return numYear;
        }

        [Required(ErrorMessage = "The category field is required")]
        public string category { get; set; }

        [Required(ErrorMessage = "The title field is required")]
        public string title { get; set; }

        [Required(ErrorMessage = "The year field is required")]
        [Range(0, 5000)]
        public int year { get; set; }

        [Required(ErrorMessage = "The director field is required")]
        public string director { get; set; }

        [Required(ErrorMessage = "The rating field is required")]
        public string rating { get; set; }

        public bool edited { get; set; }

        public string lentTo { get; set; }

        [StringLength(25, ErrorMessage = "Notes must be 25 characters or less")]
        public string notes { get; set; }
    }
}
