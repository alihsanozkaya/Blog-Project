using Blog.Core.Entities;

namespace Blog.Entity.Entities
{
    public class Article : EntityBase, IEntityBase
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int ViewCount { get; set; }
        public int CategoryId { get; set; } //Guid
        public Category Category { get; set; }
        public int ImageId { get; set; } //Guid
        public Image Image { get; set; }
    }
}