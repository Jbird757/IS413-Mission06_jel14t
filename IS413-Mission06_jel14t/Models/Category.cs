using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IS413_Mission06_jel14t.Models
{
    public class Category
    {
        [Key]
        [Required]
        public int categoryID { get; set; }
        public string categoryName { get; set; }
    }
}
