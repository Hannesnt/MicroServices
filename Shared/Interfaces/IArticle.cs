namespace Shared.Interfaces
{
    public interface IArticle
    {
        public string ArticleNumber { get; set; }

        public string? EAN { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public decimal UnitPrice { get; set; }
        public string ArticleType { get; set; }
    }
}
