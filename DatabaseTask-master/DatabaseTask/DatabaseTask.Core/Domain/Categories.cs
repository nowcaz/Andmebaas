using System;

namespace DatabaseTask.Core.Domain
{
    public class Categories
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}