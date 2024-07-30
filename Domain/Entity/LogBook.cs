
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity
{
    public class LogBook
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid BookId { get; set; }
        [ForeignKey("BookId")]
        public Book Book { get; set; }
        public int CurrentState { get; set; }
    }
}
