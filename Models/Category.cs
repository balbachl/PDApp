using System.ComponentModel.DataAnnotations;

namespace PDApp.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Display(Name = "Category")]
        [StringLength(30)]
        public string Name { get; set; }= string.Empty;

        // Navigation property
        public virtual ICollection<Resources> Resources { get; set; } = new List<Resources>();
    }
}
