using _Pustok.Areas.Manage.ViewModels;
using _Pustok.Models;

namespace _Pustok.ViewModels
{
    public class ShopViewModel
    {
        public PaginatedList<Book> Books { get; set; }
        public List<Genre> Genres { get; set; }
        public List<Author> Authors { get; set; }
        public List<Tag> Tags { get; set; }
        public decimal MaxPrice { get; set; }
        public decimal MinPrice { get; set; }

    }
}
