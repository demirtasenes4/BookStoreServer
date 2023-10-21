using StoreServerTraining.SeedDatas;
using StoreServerTraining.Models;

namespace StoreServerTraining.Services;

public static class BookService
{
    public static List<Book> books = new SeedData().CreateBooks();
    public static List<Category> categories = new SeedData().CreateCategories();
}
