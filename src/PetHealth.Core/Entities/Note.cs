﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetHealth.Core.Entities
{
    public class Note
    {
        [Key] public string Id { get; set; }
        [Required] public string PersonId { get; set; }
        [Required] public long PetId { get; set; }
        [ForeignKey("PetId")] public Pet Pet { get; set; }
        [ForeignKey("PersonId")] public ApplicationUser Person { get; set; }
        [Required] public DateTime Date { get; set; }
        public string Place { get; set; }
        public string Doctor { get; set; }
        public string Notes { get; set; }
    }
}