
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    public class SubCategory
    {
        public Guid Id { get; set; }
        [Required(ErrorMessageResourceType = typeof(Resources.DataResource), ErrorMessageResourceName = "Required")]
        [MaxLength(100, ErrorMessageResourceType = typeof(Resources.DataResource), ErrorMessageResourceName = "NameMaxLength")]
        [MinLength(3, ErrorMessageResourceType = typeof(Resources.DataResource), ErrorMessageResourceName = "NameMinLength")]
        public string Name { get; set; }
        public Guid CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        public int CurrentState { get; set; }
    }
}
