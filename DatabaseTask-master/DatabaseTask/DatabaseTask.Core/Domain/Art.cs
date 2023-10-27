using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Art
    {
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int ArtistId { get; set; }
        public DateTime CreationYear { get; set; }
        [ForeignKey("Artist")]
        public int Price { get; set; }
    }
}