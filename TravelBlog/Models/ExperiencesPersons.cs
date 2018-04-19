using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TravelBlog.Models
{
    [Table("ExperiencesPersons")]
    public class ExperiencesPersons
    {
        [Key]
        public int Id { get; set; }
        public int ExperienceId { get; set; }
        public virtual Experience Experience { get; set; }
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
    }
}
