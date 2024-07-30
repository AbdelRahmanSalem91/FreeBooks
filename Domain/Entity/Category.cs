
using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public class Category
    {
        public Guid Id { get; set; }
        [Required(ErrorMessageResourceType = typeof(Resources.DataResource), ErrorMessageResourceName = "Required")]
        [MaxLength(100, ErrorMessageResourceType = typeof(Resources.DataResource), ErrorMessageResourceName = "NameMaxLength")]
        [MinLength(3, ErrorMessageResourceType = typeof(Resources.DataResource), ErrorMessageResourceName = "NameMinLength")]
        public string Name { get; set; }
        public string Description { get; set; }
        public int CurrentState { get; set; }

    }
}
