using System.Collections.Generic;

namespace apilibrary.Models
{
    public class Library
    {
        public Library(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();
    }
}