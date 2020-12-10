using System.ComponentModel.DataAnnotations;

namespace apilibrary.Models
{
    public class Book
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Description { get; set; }
        public bool IsAvailable { get; set; }

        public override string ToString()
        {
            return $"{Title} by {Author}";
        }

        //constructor
        public Book(string title, string author, string description)
        {
            Title = title;
            Author = author;
            Description = description;
            IsAvailable = true;
        }
    }
}