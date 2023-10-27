using System;

namespace DatabaseTask.Core.Domain
{
    public class Artist
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        [ForeignKey("Gallery")]
        public int GalleryId { get; set; }
    }
}