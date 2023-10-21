using Microsoft.VisualBasic;
using StoreServerTraining.Models;

namespace StoreServerTraining.SeedDatas;

public class SeedData
{
    private List<Book> books = new();
    private List<Category> categories = new();
    private List<BookCategory> bookCategory = new();

    public List<Book> CreateBooks()
    {
        for (int i = 0; i < 50; i++)
        {
            var book = new Book
            {
                Id = i + 1,
                Title = $"Book {i + 1}",
                Author = $"{i + 1} Author",
                Summary = $"Summary {i + 1}",
                Price = i * 3,
                ImageUrl = "https://justpublishingadvice.com/wp-content/uploads/2017/02/How-to-use-URL-links.png",
                ISBN = "368-9849875",
                Stock = (i + 1) * 10,
            };
            books.Add(book);
        }
        return books;
    }

    public List<Category> CreateCategories() 
    {
        for (int i = 0; i < 10; i++)
        {
            var category = new Category
            {
                Id = i + 1,
                Name = $"Action {i + 1}",
            };
            categories.Add(category);
        }
        return categories;
    }
}
