
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    public class Book
    {
        public Guid Id { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources.DataResource), ErrorMessageResourceName = "Required")]
        [MaxLength(100, ErrorMessageResourceType = typeof(Resources.DataResource), ErrorMessageResourceName = "NameMaxLength")]
        [MinLength(3, ErrorMessageResourceType = typeof(Resources.DataResource), ErrorMessageResourceName = "NameMinLength")]
        public string Name { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources.DataResource), ErrorMessageResourceName = "Required")]
        [MaxLength(100, ErrorMessageResourceType = typeof(Resources.DataResource), ErrorMessageResourceName = "NameMaxLength")]
        [MinLength(3, ErrorMessageResourceType = typeof(Resources.DataResource), ErrorMessageResourceName = "NameMinLength")]
        public string Author { get; set; }
        public string ImageName{ get; set; }
        public bool Published { get; set; }

        public Guid CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        public Guid SubCategoryId { get; set; }

        [ForeignKey("SubCategoryId")]
        public SubCategory SubCategory { get; set; }

        public int CurrentState { get; set; }
    }
}
