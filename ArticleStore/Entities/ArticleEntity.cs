using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Shared.Interfaces;

namespace ArticleStore.Entities
{
    public class ArticleEntity : IArticle
    {
        [Key]
        public string ArticleNumber { get; set; } = null!;
        public string? EAN { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        [Column(TypeName = "Money")]
        public decimal UnitPrice { get; set; }
        public string ArticleType { get; set; } = null!;
    }
}
