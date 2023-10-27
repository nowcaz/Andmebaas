﻿using System;

namespace DatabaseTask.Core.Domain
{
    public class Owner
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        [ForeignKey("Artwork")]
        public int ArtworkId { get; set; }
    }
}