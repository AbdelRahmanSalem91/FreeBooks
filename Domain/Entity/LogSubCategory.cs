using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    public class LogSubCategory
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid SubCategoryId { get; set; }
        [ForeignKey("SubCategoryId")]
        public SubCategory SubCategory { get; set; }
        public int CurrentState { get; set; }
    }
}
