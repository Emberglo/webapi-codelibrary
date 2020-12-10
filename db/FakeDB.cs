using System.Collections.Generic;
using apilibrary.Models;

namespace apilibrary.db
{
    public class FakeDB
    {
        public static List<Book> Books { get; set; } = new List<Book>()
        {
            // RyansLibrary = new Library("Ryan's Library"),
            new Book("Guide To Monsters", "Volo", "A deep dive into the lore behind some of D&D’s most popular and iconic monsters"),
            new Book("Guide To Everything", "Xanathar", "The beholder Xanathar—Waterdeep’s most infamous crime lord—is known to hoard information on friend and foe alike. The beholder catalogs lore about adventurers and ponders methods to thwart them. Its twisted mind imagines that it can eventually record everything!"),
            new Book("Tomb of Foes", "Mordenkainen", "This tome is built on the writings of the renowned wizard from the world of Greyhawk, gathered over a lifetime of research and scholarship."),
            new Book("Cauldron of Everything", "Tasha", "The wizard Tasha, whose great works include the spell Tasha’s hideous laughter, has gathered bits and bobs of precious lore during her illustrious career as an adventurer.")
        };
    }
}