﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBlog.Models
{
    [Table("Persons")]
    public class Person
    {
        public Person()
        {
        }
        [Key]
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //public List<int> ExperienceId { get; set; }
        //public List<int> LocationId { get; set; }
        //public virtual ICollection<Experience> Experiences { get; set; }
        //public virtual ICollection<Location> Locations { get; set; }
    }
}
