using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthTest.Resource.Api.Models
{
    public class BookStore
    {
        public List<Book> Books => new List<Book>
        {
            new Book {Id = 1, Author = "J. K. Rowling", Title = "Harry Potter and the Philosopher`s Stone", Price = 10.45M },
            new Book {Id = 2, Author = "Herman Melville", Title = "Moby-Dick)", Price = 8.52M },
            new Book {Id = 3, Author = "Jules Verne", Title = "The Mysterious Island", Price = 7.11M },
            new Book {Id = 4, Author = "Carlo Collodi", Title = "The Adventures of Pinocchio", Price = 6.42M }
        };

        public Dictionary<Guid, int[]> Orders => new Dictionary<Guid, int[]>
        {
            { Guid.Parse("e2371dc9-a849-4f3c-9004-df8fc921c13a"), new int[] {1, 3 } },
            { Guid.Parse("7b0a1ec1-80f5-46b5-a108-fb938d3e26c0"), new int[] {2, 3, 4} }
        };
    }
}
