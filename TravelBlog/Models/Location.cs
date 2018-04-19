using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBlog.Models
{
    [Table("Locations")]
    public class Location
    {
       
        [Key]
        public int LocationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<Experience> Experiences { get; set; }

    }
}
