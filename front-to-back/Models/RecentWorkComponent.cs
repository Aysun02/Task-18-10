using System.ComponentModel.DataAnnotations;

namespace front_to_back.Models
{
    public class RecentWorkComponent
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name must be declared"), MinLength(3, ErrorMessage = "The Name must have a minimum length of 3")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Title must be declared"), MinLength(10, ErrorMessage = "The Title must have a minimum length of 3")]
        public string Text { get; set; }
        [Required(ErrorMessage = "Text must be declared")]
        public string FilePath { get; set; }
    }
}
