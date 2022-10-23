using System.ComponentModel.DataAnnotations;

namespace front_to_back.Models
{
    public class Category
    {
        public Category()
        {
            CategoryComponents = new List<CategoryComponent>();
        }
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter Name!"), MinLength(3, ErrorMessage = "The name must have a minimum length of 3")]
        public string Title { get; set; }
        public ICollection<CategoryComponent> CategoryComponents { get; set; }
    }
}